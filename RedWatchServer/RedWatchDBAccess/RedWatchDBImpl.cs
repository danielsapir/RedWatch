using Microsoft.Data.SqlClient;
using RedWatchLib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace RedWatchServer.RedWatchDBAccess
{
     public class RedWatchDBImpl : IRedWatchDBAccessor
     {
          public SqlConnection SqlConnection { get; private set; }
          private static readonly string sr_ConnectionString = "Data Source=DESKTOP-RLA21SQ\\SQLEXPRESS;Initial Catalog=RedWatchDB;Integrated Security=True";

          public void AddNewWatchOwner(WatchOwner i_WatchOwnerToAdd)
          {
               using (SqlConnection = new SqlConnection(sr_ConnectionString))
               using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM WatchOwners", SqlConnection))
               {
                    //DataTable allWatchOwners
                    //adapter.Fill()
               }
          }

          public void ConnectToDB()
          {
               throw new NotImplementedException();
          }

          public void ExectuteQuery(string i_QueryToExecute)
          {
               throw new NotImplementedException();
          }

          public WatchOwner GetWatchOwnerByEmailAddress(string i_EmailAddress)
          {
               throw new NotImplementedException();
          }

          public bool IsSignUpValuesAreValid(string i_EmailAddress, string i_Password)
          {
               throw new NotImplementedException();
          }

          public bool IsWatchOwnerEmailExist(string i_WatchOwnerEmailToCheck)
          {
               throw new NotImplementedException();
          }
     }
}
