using EPOSLibrary.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace EPOSLibrary
{
    public static class MergeSorter
    {
        public static List<ProductModel> MergeSort(this List<ProductModel> products)
        {
            if (products.Count <= 1) return products; // Base case

            // Create a left list and a right list
            var left = new List<ProductModel>();
            var right = new List<ProductModel>();

            // Split the input list into the left and right list evenly
            for (int i = 0; i < products.Count; i++)
            {
                if (i < products.Count / 2)
                {
                    left.Add(products[i]);
                }
                else
                {
                    right.Add(products[i]);
                }
            }

            // Recursively split the left and right lists
            left = MergeSort(left);
            right = MergeSort(right);

            // Merge the two lists (which are either sorted or atomic)
            return Merge(left, right);
        }

        private static List<ProductModel> Merge(List<ProductModel> left, List<ProductModel> right)
        {
            var result = new List<ProductModel>();

            while (left.Count > 0 && right.Count > 0) // While neither list is empty
            {
                // Get the first item in each list
                string leftFirst = ((ProductModel)left.First()).Description;
                string rightFirst = ((ProductModel)right.First()).Description;

                // Place the smaller item into the results list
                if (CompareStrings(leftFirst, rightFirst) <= 0) // IF leftFirst <= rightFirst
                {
                    result.Add(left.First());
                    left.RemoveAt(0);
                }
                else
                {
                    result.Add(right.First());
                    right.RemoveAt(0);
                }
            }

            // There may still be an item in one of the lists
            while(left.Count > 0)
            {
                result.Add(left.First());
                left.RemoveAt(0);
            }
            while (right.Count > 0)
            {
                result.Add(right.First());
                right.RemoveAt(0);
            }

            return result;
        }

        /// <summary>
        /// This is used to compare the strings in alphanumeric order (instead of
        /// just in order of the character's ASCII values)
        /// </summary>
        /// <returns>
        /// -1: stringX is less than stringY
        /// 0: stringX equals stringY
        /// 1: stringX is greater than stringY
        /// </returns>
        private static int CompareStrings(string stringX, string stringY)
        {
            if (stringX == stringY)
            {
                return 0;
            }

            // Split the strings into chunks of type
            // E.g.: "hello123world" ---> ['hello', '123', 'world']
            List<string> xStringChunks = stringX.SplitStringToChunks();
            List<string> yStringChunks = stringY.SplitStringToChunks();

            int i = 0;
            while (i < xStringChunks.Count && i < yStringChunks.Count)
            {
                // Compare the type of the front chunks (whether they are numeric or not)

                bool isChunkXNumeric = xStringChunks[i].IsNumeric();
                bool isChunkYNumeric = yStringChunks[i].IsNumeric();

                if (isChunkXNumeric && isChunkYNumeric)
                {
                    // Since they are both numeric, the lower integer
                    // value comes first when in order

                    // Both are numeric. Compare numbers
                    int xAsInt = Int32.Parse(xStringChunks[i]);
                    int yAsInt = Int32.Parse(yStringChunks[i]);
                    if (xAsInt > yAsInt)
                    {
                        // y comes first
                        return 1;
                    }
                    else if (xAsInt == yAsInt)
                    {
                        // These chunks have the same value as each other,
                        // compare the next two chunks
                        i++;
                    }
                    else
                    {
                        // x comes first
                        return -1;
                    }
                }

                else if (!isChunkXNumeric && !isChunkYNumeric)
                {
                    // Neither are numberic. Compare letters
                    int chunksCompared = string.Compare(xStringChunks[i], yStringChunks[i]);
                    if (chunksCompared == -1)
                    {
                        // y comes first
                        return -1;
                    }
                    else if (chunksCompared == 0)
                    {
                        // These chunks have the same value as each other,
                        // compare the next two chunks
                        i++;
                    }
                    else
                    {
                        // x comes first
                        return 1;
                    }
                }

                else if (!isChunkXNumeric && isChunkYNumeric)
                {
                    return 1;
                }
                else if (isChunkXNumeric && !isChunkYNumeric)
                {
                    return -1;
                }
            }

            throw new Exception(); // this point in the code shouldn't get reached
        }
    }
}
