using Microsoft.AspNetCore.SignalR;
using RedWatchLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedWatchServer.Hubs
{
     public class HomeFrontCommandHub : Hub
     {
          public void NewAlarm(eCity i_CityWithAlarm)
          {
               HubsHolder.ClientServiceHubContext.Clients.All.SendAsync("NewAlarm", i_CityWithAlarm);
          }
     }
}
