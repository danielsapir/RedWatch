using Microsoft.AspNetCore.SignalR;
using RedWatchLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace RedWatchServer.Hubs
{
     public class ClientServiceHub  : Hub
     {
          public async Task<bool> RegisterFirstStep(WatchOwner i_NewWatchOwner)
          {
               bool emailExist;
               if (EngineFacade.Instance.IsWatchOwnerExists(i_NewWatchOwner))
               {
                    emailExist = true;
               }
               else
               {
                    EngineFacade.Instance.FirstTimeAuthentication(i_NewWatchOwner);
                    emailExist = false;
               }

               return emailExist;
          }

          public async Task<bool> RegisterSecondStep(WatchOwner i_NewWatchOwner, int i_UserGeneratedCodeTry)
          {
               bool registrationSucceded = EngineFacade.Instance.SecondTimeAuthentication(i_NewWatchOwner, i_UserGeneratedCodeTry);

               return registrationSucceded;

          }

          public async Task<WatchOwner> SignIn(WatchOwner i_WatchOwner)
          {
               WatchOwner watchOwnerSignedIn = null;

               if (EngineFacade.Instance.IsWatchOwnerExists(i_WatchOwner))
               {
                    if(EngineFacade.Instance.IsWatchOwnerPasswordMatch(i_WatchOwner))
                    {
                         watchOwnerSignedIn =  EngineFacade.Instance.GetWatchOwnerByEmailAddress(i_WatchOwner.Email);
                         EngineFacade.Instance.WatchOwnerLoggedIn(watchOwnerSignedIn, Context.ConnectionId);
                    }
               }

               return watchOwnerSignedIn;
          }

          //Should be called only by Homefront Command and never by a watch owner client side code
          public void HFCHasNewAlarm(eCity i_City)
          {
               Clients.All.SendAsync("NewAlarm", i_City);
          }

          public void WatchOwnerInRedAlertZone(WatchOwner i_WatchOwnerInRedAlertZone)
          {
               EngineFacade.Instance.NotifyAllContactsOfTheUserAboutRedAlert(EngineFacade.Instance.GetWatchOwnerByEmailAddress(i_WatchOwnerInRedAlertZone.Email));
          }

          public void WatchOwnerCurrentSituation(WatchOwner i_WatchOwnerInRedAlertZone, eWatchOwnerCurrentSituation i_WatchOwnerCurrentSituation)
          {
               EngineFacade.Instance.NotifyAllContactsOfTheUserAboutItsCurrentSituation(i_WatchOwnerInRedAlertZone, i_WatchOwnerCurrentSituation);
          }

          public override Task OnDisconnectedAsync(Exception exception)
          {
               EngineFacade.Instance.WatchOwnerDisconnected(Context.ConnectionId);
               return base.OnDisconnectedAsync(exception);
          }

          public async Task<bool> IsEmailAddressExists(string i_EmailAddressToCheck)
          {
               return EngineFacade.Instance.GetWatchOwnerByEmailAddress(i_EmailAddressToCheck) != null;
          }
     }
}
