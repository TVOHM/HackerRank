using HackerRank.WarmUpChallenges.RepeatedString;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRankTests.WarmUpChallengesTests
{
    [TestClass]
    public class CharacterACounterTests
    {
        [TestMethod]
        [DataRow("aba", 10, 7)]
        [DataRow("a", 1000000000000, 1000000000000)]
        public void CorrectlyCountsNumberOfValleys(string input, long substringLength, long expectedCharacterACount)
        {
            using (new ConsoleInputs(input, substringLength))
            {
                long characterACount = new CharacterACounter().CountCharacterA();
                Assert.AreEqual(expectedCharacterACount, characterACount);
            }
        }
    }
}
