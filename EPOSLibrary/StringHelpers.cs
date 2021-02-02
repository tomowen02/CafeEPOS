using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPOSLibrary
{
    public static class StringHelpers
    {
        public static List<String> SplitStringToChunks(this string str)
        {
            int leadingMarker = 0;
            List<string> chunksList = new List<string>();
            bool chunkAdded = true;
            int followMarker = 0;

            // While there are still characteres left in the string
            while (leadingMarker != str.Length)
            {
                // If the leading marker needs to be reset due to this being the first pass, or a new string Chunk has been found
                if (chunkAdded == true)
                {
                    followMarker = leadingMarker;
                    chunkAdded = false;
                }


                if (leadingMarker + 1 < str.Length)
                {
                    string leadingChar = str[leadingMarker].ToString();
                    string leadingCharPlusOne = str[leadingMarker + 1].ToString();
                    // If the character after the leading marker is not of the same type as the following character, then there must be a new chunk
                    if (leadingChar.IsNumeric() != leadingCharPlusOne.IsNumeric())
                    {
                        string newSubString = str.Substring(followMarker, leadingMarker + 1 - followMarker);
                        chunksList.Add(newSubString);
                        chunkAdded = true;
                    }
                }
                // Else there are no more characters after the leading marker
                else
                {
                    string newSubString = str.Substring(followMarker, leadingMarker+1 - followMarker); // TODO - SHOULD HAVE A +1 AT THE END!!!
                    chunksList.Add(newSubString);
                    chunkAdded = true;
                }

                leadingMarker++;
            }
            return chunksList;
        }

        public static bool IsNumeric(this string value)
        {
            bool result = Int32.TryParse(value, out int x);
            return result;
        }
    }
}