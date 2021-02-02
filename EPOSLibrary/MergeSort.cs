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
        /*
        public static List<ProductModel> MergeSortTEMP(this List<ProductModel> products)
        {
            return products = MergeSort(products);
        }*/

        public static List<ProductModel> MergeSort(this List<ProductModel> products)
        {
            if (products.Count <= 1) return products;

            var left = new List<ProductModel>();
            var right = new List<ProductModel>();
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

            left = MergeSort(left);
            right = MergeSort(right);

            return Merge(left, right);
        }

        private static List<ProductModel> Merge(List<ProductModel> left, List<ProductModel> right)
        {
            var result = new List<ProductModel>();

            while (left.Count > 0 && right.Count > 0)
            {
                string leftFirst = ((ProductModel)left.First()).Description;
                string rightFirst = ((ProductModel)right.First()).Description;

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

        private static int CompareStrings(string stringX, string stringY)
        {
            if (stringX == stringY)
            {
                return 0;
            }

            List<string> xStringChunks = stringX.SplitStringToChunks();
            List<string> yStringChunks = stringY.SplitStringToChunks();

            int i = 0;
            while (i < xStringChunks.Count && i < yStringChunks.Count)
            {
                bool isChunkXNumeric = xStringChunks[i].IsNumeric();
                bool isChunkYNumeric = yStringChunks[i].IsNumeric();

                if (isChunkXNumeric && isChunkYNumeric)
                {
                    // Both are numberic. Compare numbers
                    int xAsInt = Int32.Parse(xStringChunks[i]);
                    int yAsInt = Int32.Parse(yStringChunks[i]);
                    if (xAsInt > yAsInt)
                    {
                        // y comes first
                        return 1;
                    }
                    else if (xAsInt == yAsInt)
                    {
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
                        return -1;
                    }
                    else if (chunksCompared == 0)
                    {
                        i++;
                    }
                    else
                    {
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

            // Should never get here
            Console.WriteLine("!!!!!!!!!!!");
            return 0;
        }
    }
}
