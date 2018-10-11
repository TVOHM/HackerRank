using HackerRank.WarmUpChallenges.CountingValleys;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace HackerRankTests.WarmUpChallengesTests
{
    [TestClass]
    public class VallyerCounterTests
    {
        [TestMethod]
        [DataRow("UDDDUDUU", 1)]
        public void CorrectlyCountsNumberOfValleys(string input, int expectedValleyCount)
        {
            using (new ConsoleInputs(input.Length, input))
            {
                int valleyCount = new ValleyCounter().CountValleys();
                Assert.AreEqual(expectedValleyCount, valleyCount);
            }
        }
    }
}
