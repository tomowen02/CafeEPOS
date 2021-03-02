using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EPOSLibrary.LoginSystem
{
    public static class Validation
    {
        public static void ValidatePassword(string password)
        {
            string errorMessage = "";

            var hasMiniMaxChars = new Regex(@".{8,50}");
            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasLowerChar = new Regex(@"[a-z]+");
            var hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");

            if (!hasMiniMaxChars.IsMatch(password))
            {
                errorMessage = "The password needs to contain 8-50 characters";
                throw new Exception(errorMessage);
            }
            else if (!hasLowerChar.IsMatch(password))
            {
                errorMessage = "The password needs to contain a lowercase number";
                throw new Exception(errorMessage);
            }
            else if (!hasUpperChar.IsMatch(password))
            {
                errorMessage = "The password needs to contain an upper case letter";
                throw new Exception(errorMessage);
            }
            else if (!hasNumber.IsMatch(password))
            {
                errorMessage = "The password needs to contain a digit";
                throw new Exception(errorMessage);
            }
            else if (!hasSymbols.IsMatch(password))
            {
                errorMessage = "The password needs to contain a special character";
                throw new Exception(errorMessage);
            }
        }
    }
}
