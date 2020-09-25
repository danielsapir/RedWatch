using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.Data.SqlClient;
using RedWatchLib;
using RedWatchServer.EmailUtils;
using RedWatchServer.Exceptions;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Security.Policy;
using System.Threading.Tasks;

namespace RedWatchServer
{
     public class EngineFacade
     {
          public Dictionary<string, WatchOwner> AllWatchOwners { get; set; }
          private EmailSender m_EmailSender;
          private static object s_SingletonLock = new object();
          private static EngineFacade s_EngineSingleton = null;
          private Dictionary<int, WatchOwner> m_GeneratedCodesToUser = new Dictionary<int, WatchOwner>();
          public static int s_CodeGenerator = 100_000;

          private EngineFacade()
          {
               AllWatchOwners = new Dictionary<string, WatchOwner>();
               m_EmailSender = new EmailSender("noreply@redwatch.com");
               //SqlConnection
          }

          public static EngineFacade Instance
          {
               get
               {
                    if (s_EngineSingleton == null)
                    {
                         lock (s_SingletonLock)
                         {
                              if (s_EngineSingleton == null)
                              {
                                   s_EngineSingleton = new EngineFacade();
                              }
                         }
                    }

                    return s_EngineSingleton;
               }
          }

          public void FirstTimeAuthentication(WatchOwner i_NewWatchOwner)
          {
               if (AllWatchOwners.ContainsKey(i_NewWatchOwner.Email))
               {
                    throw new UserAlreadyExistException() { WatcherOwnedExists = i_NewWatchOwner };
               }
               else
               {
                    string firstMessageSubject = "Welcome to redWatch " + i_NewWatchOwner.Name + "!";
                    string firstMessageBody = "Please enter the following generated code in your login form: "
                         + generateNewRegisterationCode(i_NewWatchOwner).ToString();
                    MailMessage firstMessage = i_NewWatchOwner.MakeMailMessageToWatchOwner(firstMessageSubject, firstMessageBody);
                    //firstMessage.From = new MailAddress("redwatchserver@gmail.com");
                    m_EmailSender.SendMessage(firstMessage);
               }
          }

          public void WatchOwnerLoggedIn(WatchOwner i_WatchOwner, string i_WatchOnweConnectionId)
          {
               i_WatchOwner.ConnectionID = i_WatchOnweConnectionId;
          }

          public bool IsWatchOwnerPasswordMatch(WatchOwner i_WatchOwner)
          {
               WatchOwner watchOwnerToBeSignedIn = GetWatchOwnerByEmailAddress(i_WatchOwner.Email);

               return i_WatchOwner.Password.Equals(watchOwnerToBeSignedIn.Password);
          }

          private int generateNewRegisterationCode(WatchOwner i_NewWatchOwner)
          {
               m_GeneratedCodesToUser.Add(s_CodeGenerator, i_NewWatchOwner);

               return s_CodeGenerator++;
          }

          public void WatchOwnerDisconnected(string i_WatchOwnerConnectionId)
          {
               WatchOwner disconnectedWatchOwner = getWatchOwnerByConnectionID(i_WatchOwnerConnectionId);
               if (disconnectedWatchOwner != null)
               {
                    m_EmailSender.SendMessage(disconnectedWatchOwner.MakeMailMessageToWatchOwnerContacts(
                         disconnectedWatchOwner.Name + " got disconected!",
                         disconnectedWatchOwner.Name + " got disconnected from our RedWatch server." + Environment.NewLine +
                         "Please check maybe " + disconnectedWatchOwner.Name + "'s watch is turned off."));
                    m_EmailSender.SendMessage(disconnectedWatchOwner.MakeMailMessageToWatchOwner(
                           "You got disconnect from RedWatch server.",
                         "You got disconnect from RedWatch server." + Environment.NewLine +
                         "Please check if your watch is off."));
               }
          }

          private WatchOwner getWatchOwnerByConnectionID(string i_WatchOwnerConnectionId)
          {
               foreach (WatchOwner watchOwner in AllWatchOwners.Values)
               {
                    if (watchOwner.ConnectionID.Equals(i_WatchOwnerConnectionId))
                    {
                         return watchOwner;
                    }
               }

               return null;
          }

          public bool SecondTimeAuthentication(WatchOwner i_NewWatchOwner, int i_UserGeneratedCodeTry)
          {
               WatchOwner watchOwnerFromGeneratedCode;
               bool registrationSucceded;

               if(m_GeneratedCodesToUser.TryGetValue(i_UserGeneratedCodeTry, out watchOwnerFromGeneratedCode))
               {
                    registrationSucceded = (watchOwnerFromGeneratedCode.Email).Equals(i_NewWatchOwner.Email);
                    addWatchOwnerToDB(i_NewWatchOwner);
                    m_GeneratedCodesToUser.Remove(i_UserGeneratedCodeTry);
                    MailMessage successMessage = i_NewWatchOwner.MakeMailMessageToWatchOwner("We got your back!", "You succefully registerd");
                    //successMessage.From = new MailAddress("redwatchserver@gmail.com");
                    m_EmailSender.SendMessage(successMessage);
               }
               else
               {
                    registrationSucceded = false;
               }

               return registrationSucceded;
          }

          public bool AddNewWatchOwner(WatchOwner i_NewWatchOwner)
          {
               if (IsWatchOwnerExists(i_NewWatchOwner))
               {
                    return false;
               }

               addWatchOwnerToDB(i_NewWatchOwner);
               return true;
          }

          private void addWatchOwnerToDB(WatchOwner i_NewWatchOwner)
          {
               AllWatchOwners.Add(i_NewWatchOwner.Email, i_NewWatchOwner);

          }

          public bool IsWatchOwnerExists(WatchOwner i_NewWatchOwner)
          {
               return AllWatchOwners.ContainsKey(i_NewWatchOwner.Email);
          }

          public bool IsWatchOwnerExists(WatchOwner i_NewWatchOwner, out WatchOwner o_WatchOwnerFound)
          {
               WatchOwner watchOwnerFound = null;
               bool isWatchOwnerExist = IsWatchOwnerExists(i_NewWatchOwner);

               if(isWatchOwnerExist)
               {
                    watchOwnerFound = GetWatchOwnerByEmailAddress(i_NewWatchOwner.Email);
               }

               o_WatchOwnerFound = watchOwnerFound;
               return isWatchOwnerExist;
          }

          public WatchOwner GetWatchOwnerByEmailAddress(string i_EmailAddress)
          {
               WatchOwner watchOwnerFound;

               AllWatchOwners.TryGetValue(i_EmailAddress, out watchOwnerFound);

               return watchOwnerFound;
          }

          public void NotifyAllContactsOfTheUserAboutRedAlert(WatchOwner i_WatchOwnerInRedAlertZone)
          {
               MailMessage contactsMailMessage = i_WatchOwnerInRedAlertZone.MakeMailMessageToWatchOwnerContacts(
                    i_WatchOwnerInRedAlertZone.Name + " is in red alert zone",
                    i_WatchOwnerInRedAlertZone.Name + " is in red alert zone");
               m_EmailSender.SendMessage(contactsMailMessage);
          }

          public void NotifyAllContactsOfTheUserAboutItsCurrentSituation(WatchOwner i_WatchOwnerInRedAlertZone, eWatchOwnerCurrentSituation i_WatchOwnerCurrentSituation)
          {
               string messageSubject = null;
               string messageBody = null;
               switch (i_WatchOwnerCurrentSituation)
               {
                    case eWatchOwnerCurrentSituation.INHM:
                         messageSubject = i_WatchOwnerInRedAlertZone.Name + " NEEDS HELP!";
                         messageBody = i_WatchOwnerInRedAlertZone.Name
                              + " is in red alert zone and needs help!" + Environment.NewLine
                              + "Please contact him immidatly!";
                         break;
                    case eWatchOwnerCurrentSituation.IOKM:
                         messageSubject = i_WatchOwnerInRedAlertZone.Name + " is OK";
                         messageBody = i_WatchOwnerInRedAlertZone.Name
                              + " is in red alert zone and he is OK";
                         break;
               }

               m_EmailSender.SendMessage(i_WatchOwnerInRedAlertZone.MakeMailMessageToWatchOwnerContacts(messageSubject, messageBody));
          }
     }
}
