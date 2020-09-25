using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Net.Mail;
using System.Runtime.Serialization;
using System.Text;

namespace RedWatchLib
{
     public class WatchOwner
     {
          private static readonly int  sr_MaxNumberOfContacts = 3;

          private string m_Email;
          public string Email 
          { 
               get { return m_Email; } 
               set
               {
                    m_Email = new EmailAddressAttribute().IsValid(value) ? value : null;
               }
          }

          public string Name { get; set; }
          public string Password { get; set; }
          public Contact[] Contacts { get; set; }
          public eCity City { get; set; }

          public string ConnectionID { get; set; }

          public WatchOwner()
          {
               Contacts = new Contact[sr_MaxNumberOfContacts];
          }

          public MailMessage MakeMailMessageToWatchOwner(string i_Subject, string i_Body)
          {
               MailMessage newMailMessage = makeBaseMailMessage(i_Subject, i_Body);

               newMailMessage.To.Add(Email);

               return newMailMessage;
          }

          private MailMessage makeBaseMailMessage(string i_Subject, string i_Body)
          {
               MailMessage newMailMessage = new MailMessage();

               newMailMessage.Subject = i_Subject;
               newMailMessage.Body = i_Body;
               return newMailMessage;
          }

          public MailMessage MakeMailMessageToWatchOwnerContacts(string i_Subject, string i_Body)
          {

               MailMessage newMailMessage = makeBaseMailMessage(i_Subject, i_Body);

               foreach (Contact watchOwnerContact in Contacts)
               {
                    if (watchOwnerContact.Email != null)
                    {
                         newMailMessage.To.Add(watchOwnerContact.Email);
                    }
               }

               return newMailMessage;

          }

          public override bool Equals(object obj)
          {
               return obj is WatchOwner owner &&
                      Name == owner.Name &&
                      Password == owner.Password &&
                      EqualityComparer<Contact[]>.Default.Equals(Contacts, owner.Contacts) &&
                      City == owner.City &&
                      Email == owner.Email;
          }

          public override int GetHashCode()
          {
               int hashCode = 62549504;
               hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(m_Email);
               hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
               hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Password);
               hashCode = hashCode * -1521134295 + EqualityComparer<Contact[]>.Default.GetHashCode(Contacts);
               hashCode = hashCode * -1521134295 + City.GetHashCode();
               return hashCode;
          }
     }
}
