using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPOSLibrary.Models
{
    public class EmployeeModel
    {
        /// <summary>
        /// This is the identifying field for an employee
        /// </summary>
        public string EmployeeUsername { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        /// <summary>
        /// This will be compared against when an employee attempts to login to their account
        /// </summary>
        public string HashedPass { get; set; }
        public bool isActive { get; set; }
        public int RoleID { get; set; }
        public string Salt { get; set; }
    }
}
