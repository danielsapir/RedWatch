using RedWatchLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedWatchServer.Exceptions
{
     public class UserAlreadyExistException : Exception
     {
          public WatchOwner WatcherOwnedExists { get; set; }
     }
}
