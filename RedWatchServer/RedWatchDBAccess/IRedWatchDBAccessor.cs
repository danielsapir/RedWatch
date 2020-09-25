using Microsoft.Data.SqlClient;
using RedWatchLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Threading.Tasks;

namespace RedWatchServer.RedWatchDBAccess
{
     public interface IRedWatchDBAccessor
     {
          SqlConnection SqlConnection { get; }
          void ConnectToDB();
          void AddNewWatchOwner(WatchOwner i_WatchOwnerToAdd);
          bool IsWatchOwnerEmailExist(string i_WatchOwnerEmailToCheck);
          bool IsSignUpValuesAreValid(string i_EmailAddress, string i_Password);
          WatchOwner GetWatchOwnerByEmailAddress(string i_EmailAddress);
          void ExectuteQuery(string i_QueryToExecute);
     }
}
