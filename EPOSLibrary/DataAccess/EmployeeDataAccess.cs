using Dapper;
using EPOSLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPOSLibrary.DataAccess
{
    public class EmployeeDataAccess : ConnectionString
    {
        #region Load Employees
        public static EmployeeModel Load(string username)
        {
            using (var cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@username", username);

                var output = cnn.Query<EmployeeModel>("SELECT EmployeeUsername, Firstname, Lastname, Email, Phone, HashedPass, isActive, RoleID, Salt FROM Employees WHERE EmployeeUsername = @username", parameters).ToList();
                if (output.Count > 0)
                {
                    return output.First();
                }
                else
                {
                    return null;
                }
            }
        }

        public static string LoadHash(string username)
        {
            using (var cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@username", username);

                var output = cnn.ExecuteScalar<string>("SELECT HashedPass FROM Employees WHERE EmployeeUsername = @username", parameters);
                return output;
            }
        }

        public static string LoadSalt(string username)
        {
            using (var cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@username", username);

                var output = cnn.ExecuteScalar<string>("SELECT Salt FROM Employees WHERE EmployeeUsername = @username", parameters);
                return output;
            }
        }
        #endregion

        #region Save Employees
        public static EmployeeModel Save(EmployeeModel employee)
        {
            using (var cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("INSERT INTO Employees (EmployeeUsername, Firstname, Lastname, Email, Phone, HashedPass, isActive, RoleID) VALUES ('EmployeeUsername', 'Firstname', 'Lastname', 'Email', 'Phone', 'HashedPass', 'isActive', 'RoleID'); SELECT last_insert_rowid()", employee);
                return employee;
            }
        }
        #endregion
    }
}
