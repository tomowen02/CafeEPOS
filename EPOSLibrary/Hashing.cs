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
            password = salt + password;

            string hash = "";

            // Sqaure all of the decimal ascii values, and then multiply together
            bool firstPass = true;
            foreach (char character in password)
            {
                if (firstPass)
                {
                    hash = (Math.Pow((int)character, 2)).ToString();
                    firstPass = false;
                }
                else
                {
                    int aciiSquared = (int)Math.Pow((int)character, 2);
                    hash = (BigInteger.Parse(hash) * aciiSquared).ToString();
                }
            }

            // MOD by 16 to allow it to fit ?

            // Add ajacent pairs
            string tempHash = "";
            if (hash.Length % 2 == 1)
            {
                // Incase the string is an odd number in length (so that the last digit still has a pair)
                hash += "0";
            }
            for (int i = 0; i < hash.Length; i++)
            {
                if (i % 2 == 0)
                {
                    int one = int.Parse(hash[i].ToString());
                    int two = int.Parse(hash[i + 1].ToString());
                    tempHash += (one + two).ToString();
                }
            }
            hash = tempHash;

            // Square value
            //hash = ((int)Math.Pow(int.Parse(hash), 2)).ToString();

            // Use the MOD function to shorten this down to 8 characters long
            hash = (BigInteger.Parse(hash) % (int)Math.Pow(10, 48)).ToString();

            // Convert to charaters
            List<string> charCodes = new List<string>();
            for (int i = 0; i < hash.Length; i++)
            {
                if (i % 3 == 0)
                {
                    // New triplet
                    charCodes.Add(hash[i].ToString());
                }
                else
                {
                    charCodes[charCodes.Count - 1] += hash[i].ToString();
                }
            }
            for (int i = 0; i < charCodes.Count; i++)
            {
                int asciiCode = (int.Parse(charCodes[i]) % 94) + 33;
                charCodes[i] = ((char)asciiCode).ToString();
            }

            hash = "";
            // Join charCodes
            foreach (string charater in charCodes)
            {
                hash += charater;
            }



            return hash;
        }
    }
}
