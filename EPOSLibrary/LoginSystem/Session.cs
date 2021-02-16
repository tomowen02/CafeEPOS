using EPOSLibrary.DataAccess;
using EPOSLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPOSLibrary.LoginSystem
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

                role.RoleID = value.RoleID;
                role.RoleName = RoleDataAccess.Load(value.RoleID);
            }
        }

        private static RoleModel role = new RoleModel();
        public static RoleModel Role { get { return role; } }
    }
}
