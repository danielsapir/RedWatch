using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using RedWatchServer.Hubs;

namespace RedWatchServer
{
     public class Program
     {
          public static void Main(string[] args)
          {
               IHost host = CreateHostBuilder(args).Build();
               HubsHolder.ClientServiceHubContext = (IHubContext<ClientServiceHub>)host.Services.GetService(typeof(IHubContext<ClientServiceHub>));
               host.Run();
          }

          public static IHostBuilder CreateHostBuilder(string[] args) =>
              Host.CreateDefaultBuilder(args)
                  .ConfigureWebHostDefaults(webBuilder =>
                  {
                       webBuilder.UseStartup<Startup>();
                  });
     }
}
