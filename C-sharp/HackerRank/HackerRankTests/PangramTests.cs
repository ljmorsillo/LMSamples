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
    public class PangramTests
    {
        /// <summary>
        /// Quick test of pangram checker
        /// </summary>
        [TestMethod()]
        public void CheckForPangramTest()
        {

            Assert.IsTrue(Pangram.checkForPangram("We promptly judged antique ivory buckles for the next prize "));
            Assert.IsFalse(Pangram.checkForPangram("We promptly judged antique ivory buckles for the prize "));
            Assert.IsTrue(Pangram.checkForPangram("The quick red fox jumped over lazy brown dogs "), "TQRFJOTLBD failed");

        }
    }
}