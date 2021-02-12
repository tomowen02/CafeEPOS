using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace EPOSLibrary
{
    public static class Hashing
    {
        public static string Hash(string password, string salt)
        {
            string fullInput = salt + password;


            string hash = "";
            // Square each ascii value, multiple by the value of i, and concatenate them together
            for (int i = 0; i < fullInput.Length; i++)
            {
                int asciiValue = (int)fullInput[i]; // Get the ascii value
                asciiValue *= i; // This is to randomise the hash string a bit if the same character has been repeated lots of times
                hash += Math.Pow((int)asciiValue, 2); // Square the value and concatenate it with the hash string
            }


            // Split into chunks of three digits
            List<string> triplets = new List<string>();
            string current = "";
            for (int i = 0; i < hash.Length; i++)
            {
                if (i % 3 == 0)
                {
                    triplets.Add(current);
                    current = hash[i].ToString();
                }
                else
                {
                    current += hash[i];
                }
            }
            triplets.RemoveAt(0); // The first index has an empty string
            // We now have a list of 3 digit long strings
            
            
            // Convert chunks into the correct ranges for decimal ascii values
            hash = "";
            for (int i = 0; i < triplets.Count; i++)
            {
                int asciiValue = int.Parse(triplets[i]) % 94; // There are 94 readable characters on an acii table
                asciiValue += 33; // Makes sure that the ascii numbers are within the readable range
                if (asciiValue == 34 || asciiValue == 39) // Make sure that the character is not " or ' as these are escape characters for strings
                {
                    asciiValue += 1;
                }
                hash += (char)asciiValue;
            }

            return hash;
        }
    }
}
