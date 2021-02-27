using EPOSLibrary.DataAccess;
using EPOSLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPOSLibrary.LoginSystem
{
    public static class UserLogin
    {
        public static bool AuthenticateUserCreds(string username, string password)
        {
            EmployeeModel user = EmployeeDataAccess.Load(username); // Load the user profile to see if the user exists

            if (user != null) // If there is a user matching the username
            {
                // Retrieve the hash and the salt from the database
                string salt = user.Salt;
                string hashFromDatabase = user.HashedPass;

                if (Hashing.ComparePasswordWithHash(password, salt, hashFromDatabase))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
