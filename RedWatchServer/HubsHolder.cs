using Microsoft.AspNetCore.SignalR;
using RedWatchServer.Hubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedWatchServer
{
     public static class HubsHolder
     {
          public static IHubContext<ClientServiceHub> ClientServiceHubContext { get; set; }
     }
}
