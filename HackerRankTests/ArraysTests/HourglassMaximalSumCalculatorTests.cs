using HackerRank.Arrays.Array2DHourglasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerRankTests.ArraysTests
{
    [TestClass]
    public class HourglassMaximalSumCalculatorTests
    {
        [TestMethod]
        [DataRow(
            "-9 -9 -9 1 1 1", 
            "0 -9 0 4 3 2", 
            "-9 -9 -9 1 2 3", 
            "0 0 8 6 6 0", 
            "0 0 0 -2 0 0", 
            "0 0 1 2 4 0", 
            28)]
        [DataRow(
            "1 1 1 0 0 0",
            "0 1 0 0 0 0",
            "1 1 1 0 0 0",
            "0 0 2 4 4 0",
            "0 0 0 2 0 0",
            "0 0 1 2 4 0",
            19)]
        public void CorrectlyCountsMaximalSumOfHourglasses(string row1, string row2, string row3, string row4, string row5, string row6, long expectedMaximalHourglassSum)
        {
            using (new ConsoleInputs(row1, row2, row3, row4, row5, row6))
            {
                long maximalHourglassSum = new HourglassMaximalSumCalculator().CalculateHourglassMaximalSum();
                Assert.AreEqual(expectedMaximalHourglassSum, maximalHourglassSum);
            }
        }
    }
}
