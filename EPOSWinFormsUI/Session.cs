using EPOSLibrary.DataAccess;
using EPOSLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPOSWinFormsUI
{
    public static class Session
    {
        private static EmployeeModel employee;
        public static EmployeeModel Employee
        {
            get { return employee; }
            set 
            {
                employee = value;
                role = RoleDataAccess.Load(value.RoleID);
            }
        }

        private static string role;
        public static string Role { get { return role; } }
    }
}
