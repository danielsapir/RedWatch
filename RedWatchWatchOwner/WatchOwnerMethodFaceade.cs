using Accessibility;
using Microsoft.AspNetCore.SignalR.Client;
using RedWatchLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RedWatchWatchOwner
{
     public class WatchOwnerMethodFaceade
     {
          private HubConnection m_ServerHub;
          public WatchOwner WatchOwnerLoggedIn { get; set; }
          private readonly string r_ServerURL = "https://localhost:5001/clientservicehub";
          private static WatchOwnerMethodFaceade s_Instance = null;
          private static readonly object sr_Lock = new object();
          private bool m_ConnectionEstablished = false;

          static WatchOwnerMethodFaceade()
          {
          }

          public static WatchOwnerMethodFaceade Instance
          {
               get
               {
                    if (s_Instance == null)
                    {
                         lock (sr_Lock)
                         {
                              if (s_Instance == null)
                              {
                                   s_Instance = new WatchOwnerMethodFaceade();
                              }
                         }
                    }
                    return s_Instance;
               }
          }

          private WatchOwnerMethodFaceade()
          {
               m_ServerHub = new HubConnectionBuilder().WithAutomaticReconnect().WithUrl(r_ServerURL).Build();
          }

          public async Task connectToServerAsync()
          {
               await m_ServerHub.StartAsync();
          }

          public void WatchOwnerSendsMessage(eWatchOwnerCurrentSituation i_WatchOwnerMessage)
          {
               m_ServerHub.SendAsync("WatchOwnerCurrentSituation", WatchOwnerLoggedIn, i_WatchOwnerMessage);
          }

          public async Task<bool> RegiserationFirstStepAsync()
          {
               if (!m_ConnectionEstablished)
               {
                    connectToServerAsync();
                    m_ConnectionEstablished = true;
               }
               bool emailExist = await m_ServerHub.InvokeAsync<bool>("RegisterFirstStep", WatchOwnerLoggedIn);
               return emailExist;
          }

          public async Task<bool> RegistrationSecondStepAsync(int i_GeneratedCode)
          {
               bool registationSucceded =
                    await m_ServerHub.InvokeAsync<bool>("RegisterSecondStep", WatchOwnerLoggedIn, i_GeneratedCode);
               return registationSucceded;
          }

          public async Task<bool> SignInWatchOwner(string i_WatchOwnerEmail, string i_WatchOwnerPassword)
          {
               WatchOwner watchOwnerToSignIn = new WatchOwner() { Email = i_WatchOwnerEmail, Password = i_WatchOwnerPassword };
               WatchOwnerLoggedIn = await m_ServerHub.InvokeAsync<WatchOwner>("SignIn", watchOwnerToSignIn);

               return WatchOwnerLoggedIn != null;
          }

          public async Task<bool> IsEmailAddressExists(string i_EmailAddressToCheck)
          {
               return await m_ServerHub.InvokeAsync<bool>("IsEmailAddressExists", i_EmailAddressToCheck);
          }

          public void AddMethodToOnNewAlarm(Action i_MethodToAdd)
          {
               m_ServerHub.On<eCity>("NewAlarm", cityWithAlert => i_MethodToAdd());                
          }

          public void WatchOwnerInRedAlert()
          {
               m_ServerHub.SendAsync("WatchOwnerInRedAlertZone", WatchOwnerLoggedIn);
          }
     }
}
