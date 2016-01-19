using Microsoft.VisualStudio.TestTools.UnitTesting;
using HackerRank;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Tests
{
    [TestClass()]
    public class BinarySearchTests
    {
        protected int[] testArrayEven = { 1, 4, 6, 7, 9, 10, 20, 34, 42, 50 };     //even length
        protected int[] testArrayOdd = { 1, 4, 6, 7, 9, 10, 20, 34, 42, 47, 50 }; //odd length

        private BinarySearch bs;

        [TestInitialize()]
        public void SetupTest()
        {
            bs = new BinarySearch();
        }

        [TestMethod()]
        public void BinSearchTestFound()
        {
            //Even length array
            int retVal = bs.binarySearch(testArrayEven, 9, 0, testArrayEven.Count() - 1);
            int actual = aryItem(testArrayEven,retVal);
            Assert.AreEqual(9, actual,"Even Failed");

            //Odd length array
            retVal = bs.binarySearch(testArrayOdd, 9, 0, testArrayOdd.Count() - 1);
            actual = aryItem(testArrayOdd, retVal);
            Assert.AreEqual(9, actual,"Odd Failed");
        }

        private static int aryItem(int[] testArray, int retVal)
        {
            if (retVal >= 0)
                return (testArray[retVal]);
            else return -1; //sentinel - not a great design in this case - not for production use....
        }

        [TestMethod()]
        public void BinSearchTestNotFound()
        {
            int retVal = bs.binarySearch(testArrayEven, 11, 0, testArrayEven.Count() - 1);
            Assert.AreEqual(-1, retVal, "Even Failed");

            retVal = bs.binarySearch(testArrayOdd, 11, 0, testArrayOdd.Count() - 1);
            Assert.AreEqual(-1, retVal, "Odd Failed");

        }
        [TestMethod()]
        public void BinSearchTestFirstFound()
        {
            int retVal = bs.binarySearch(testArrayEven, 1, 0, testArrayEven.Count() - 1);
            int actual = aryItem(testArrayEven, retVal);
            Assert.AreEqual(1, actual, "Even Failed");
            
            retVal = bs.binarySearch(testArrayOdd, 1, 0, testArrayOdd.Count() - 1);
            actual = aryItem(testArrayOdd, retVal);
            Assert.AreEqual(1, actual, "Odd Failed");

        }
        [TestMethod()]
        public void BinSearchTestLastFound()
        {
            int retVal = bs.binarySearch(testArrayEven, 50, 0, testArrayEven.Count() - 1);
            int actual= aryItem(testArrayEven, retVal);
            Assert.AreEqual(50, actual, "Even Failed");

            retVal = bs.binarySearch(testArrayOdd, 50, 0, testArrayOdd.Count() - 1);
            actual = aryItem(testArrayOdd, retVal);
            Assert.AreEqual(50, actual, "Odd Failed");


        }
    }
}