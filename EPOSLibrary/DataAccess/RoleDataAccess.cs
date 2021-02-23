using Dapper;
using EPOSLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPOSLibrary.DataAccess
{
    public class RoleDataAccess : Connection<RoleModel>
    {
        public static string Load(int roleID)
        {
            string query = "SELECT RoleName FROM Roles WHERE RoleID = @RoleID";

            var parameters = new DynamicParameters();
            parameters.Add("@roleID", roleID);

            return ExecuteScalar(query, parameters);
        }
    }
}
