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
    public class EmployeeDataAccess : Connection<EmployeeModel>
    {
        public static EmployeeModel Load(string username)
        {
            string query = "SELECT EmployeeUsername, Firstname, Lastname, Email, Phone, HashedPass, isActive, RoleID, Salt FROM Employees WHERE EmployeeUsername = @username";

            var parameters = new DynamicParameters();
            parameters.Add("@username", username);

            List<EmployeeModel> output = Query(query, parameters);
            if (output.Count > 0)
            {
                return output.First();
            }
            else
            {
                return null;
            }
        }

        public static string LoadHash(string username)
        {
            string query = "SELECT HashedPass FROM Employees WHERE EmployeeUsername = @username";

            var parameters = new DynamicParameters();
            parameters.Add("@username", username);

            return ExecuteScalar(query, parameters);
        }

        public static string LoadSalt(string username)
        {
            using (var cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string query = "SELECT Salt FROM Employees WHERE EmployeeUsername = @username";

                var parameters = new DynamicParameters();
                parameters.Add("@username", username);

                return ExecuteScalar(query, parameters);
            }
        }

        public static EmployeeModel Save(EmployeeModel employee)
        {
            string query = "INSERT INTO Employees" +
                "(EmployeeUsername, Firstname, Lastname, Email, Phone, HashedPass, isActive, RoleID)" +
                "VALUES (EmployeeUsername= @EmployeeUsername, Firstname = @Firstname, Lastname = @Lastname, Email = @Email, Phone = @Phone, HashedPass = @HashedPass, isActive = @isActive, RoleID = @RoleID)";

            var parameters = new DynamicParameters();
            parameters.Add("@EmployeeUsername", employee.EmployeeUsername);
            parameters.Add("@Firstname", employee.Firstname);
            parameters.Add("@Lastname", employee.Lastname);
            parameters.Add("@Email", employee.Email);
            parameters.Add("@Phone", employee.Phone);
            parameters.Add("@HashedPass", employee.HashedPass);
            parameters.Add("@isActive", employee.isActive);
            parameters.Add("@RoleID", employee.RoleID);

            Execute(query, parameters);

            return employee;
        }

        public static void ChangePassword(string employeeUsername, string hashedPassword, string salt)
        {
            string query = "UPDATE Employees SET HashedPass = @HashedPass, Salt = @Salt WHERE EmployeeUsername = @EmployeeUsername";

            var parameters = new DynamicParameters();
            parameters.Add("@EmployeeUsername", employeeUsername);
            parameters.Add("@HashedPass", hashedPassword);
            parameters.Add("@Salt", salt);

            Execute(query, parameters);
        }

        public static void CreateTable()
        {
            string query = @"
                CREATE TABLE Employees (
                    EmployeeUsername
                        STRING
                        PRIMARY KEY
                        UNIQUE
                        NOT NULL,
                    Firstname
                        STRING
                        NOT NULL,
                    Lastname
                        STRING
                        NOT NULL,
                    Email
                        STRING
                        NOT NULL,
                    Phone
                        STRING,
                    HashedPass
                        STRING,
                    isActive
                        BOOLEAN
                        NOT NULL
                        DEFAULT (True),
                    RoleID
                        INTEGER
                        REFERENCES Roles (RoleID) 
                        NOT NULL,
                    Salt
                        STRING
                );";

            Execute(query);
        }
    }
}
