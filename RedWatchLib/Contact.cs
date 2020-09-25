using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Net.Mail;
using System.Text;

namespace RedWatchLib
{
     public class Contact
     {
          private string m_Email;
          public WatchOwner ContactsWatchOwner{ get; set; } 
          public string Name { get; set; }
          public string Email
          {
               get { return m_Email; }
               set
               {
                    m_Email = new EmailAddressAttribute().IsValid(value) ? value : null;
               }
          }

          public override bool Equals(object obj)
          {
               return obj is Contact contact &&
                      m_Email == contact.m_Email &&
                      EqualityComparer<WatchOwner>.Default.Equals(ContactsWatchOwner, contact.ContactsWatchOwner) &&
                      Name == contact.Name;
          }

          public override int GetHashCode()
          {
               int hashCode = -1364132469;
               hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(m_Email);
               hashCode = hashCode * -1521134295 + EqualityComparer<WatchOwner>.Default.GetHashCode(ContactsWatchOwner);
               hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
               return hashCode;
          }
     }
}
