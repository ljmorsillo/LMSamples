using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Assortmant of little things to answer HacckerRank and other coding problems
/// Main() tests the "make change" problem - given an amount, how would you make change, starting with a specific largest
/// bill
/// Other objects ar done as Unit Tests
/// </summary>
namespace HackerRank
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("127");
            MakeChange(127, 100);

            System.Console.WriteLine("454");
            MakeChange(454, 100);

            System.Console.WriteLine("23");
            MakeChange(23, 100);

            System.Console.ReadKey();
        }

        //return remainder ( amount no change is figured for)
        static int MakeChange(int amount, int coin)
        {
            int NumCoins = amount / coin;
            int remainder = amount - (NumCoins * coin);
            System.Console.WriteLine("{0} coins of {1} unit coin. Remainder: {2}", NumCoins, coin, remainder);
            coin = FindNextLargest(remainder);
            if (coin > 1)
            {
                MakeChange(remainder, coin);
            }
            else
            {
                System.Console.WriteLine("{0} of {1} unit coin.", remainder, coin);
            }
            return remainder;
        }
        static internal int FindNextLargest(int amount)
        {
            int[] coinage = { 100, 50, 25, 10, 5, 1 };
            int retVal = 1;
            foreach (int coin in coinage)
            {
                if (amount / coin >= 1.0f)
                {
                    retVal = coin;
                    break;
                }
            }
            return (retVal);
        }


    }
    /// <summary>
    /// This determines if a string is a Pangram - i.e. It has an occurence of each and every letter in the alphabet
    /// </summary>
    public class Pangram
    {
        /// <summary>
        /// Is every character A-Z (case insensitive) and space included in string? Allows duplicates
        /// </summary>
        /// <param name="input"></param>
        /// <returns>True is a Pangram</returns>
        static public bool checkForPangram(string input)
        {
            const int NUM_ALL_CHARS = 27; //A-Z <space>
            SortedSet<string> chars = new SortedSet<string>();
            foreach(char inChar in input)
            {
                //SortedSet will not accept duplicate - each diff char counted once
                chars.Add(inChar.ToString().ToUpper());
            }
            if (chars.Count != NUM_ALL_CHARS) 
                return false;
            else
                return true;
        }
    }
    // buggy
    public class BinarySearch
    {
        /// <summary>
        /// implement a recursive function to perform binary search on a sorted array of integers to find the index of a given integer
        /// </summary>
        /// <param name="inputArray"> array to search</param>
        /// <param name="valToFind"> value to find</param>
        /// <param name="startIndex"> where (index) to start search</param>
        /// <param name="endIndex">index on where to end search</param>
        /// <returns>Index of found item or NotFound</returns>
        enum RetVals { NotFound = -1};
        public int binarySearch(int[] inputArray, int valToFind, int startIndex, int endIndex)
        {
            if (startIndex < 0 || endIndex > inputArray.Count() - 1)
            {
                throw (new ArgumentException("Invalid indices"));
            }

            //Divide the array in half, and BinarySearch on that half (and then again recursively)
            //once you have a single item array, it will either be what you seek or it means Not Found 

            int range = endIndex - startIndex;

            if (range < 0)
                return ((int)BinarySearch.RetVals.NotFound);
            int middle = startIndex + range/2;

            //Which half to check ? Top half or bottom half

            if (valToFind == inputArray[middle])
                return (middle);
            else if (range == 1 && inputArray[middle+1] != valToFind)
                return ((int)RetVals.NotFound);
            else if (valToFind > inputArray[middle])
            {
                //look in top half
                return binarySearch(inputArray, valToFind, middle + 1, endIndex);
            }
            else if (valToFind <= inputArray[middle])
            {
                //search half array of 0 to middle
                return binarySearch(inputArray, valToFind, startIndex, middle);
            }
            return -1; //not found
        }
    }
}
