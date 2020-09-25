using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Mail;
namespace RedWatchServer.EmailUtils
{
     public class EmailSender
     {
          public EmailSender(string i_SenderMailAddress)
          {

               SmtpServer = new SmtpClient("smtp-relay.sendinblue.com", 587);
               SmtpServer.Credentials = new System.Net.NetworkCredential("danielsap123@gmail.com", "IM4ymtZSCqzNFhg7");
               SmtpServer.EnableSsl = true;

               SenderMailAddress = i_SenderMailAddress;

          }

          public string SenderMailAddress {get; private set; }
          public SmtpClient SmtpServer { get; private set; }

          public async void SendMessage(MailMessage i_MailMessageToSend)
          {
               i_MailMessageToSend.From = new MailAddress("redwatchserver@gmail.com");
               SmtpServer.Send(i_MailMessageToSend);
          }
     }
}
