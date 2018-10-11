using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank.Arrays.Array2DHourglasses
{
    public class HourglassMaximalSumCalculator
    {
        private const int ArrayDimensions = 6, HourglassDimensions = 3;

        public long CalculateHourglassMaximalSum()
        {
            long[][] grid = new long[ArrayDimensions][]
                .Select(r => Console.ReadLine().Split(' ').Select(long.Parse).ToArray()).ToArray();

            long? maximalSum = null;
            // Go over every starting position of all possible hourglasses (top left position).
            for(int column = 0; column <= ArrayDimensions - HourglassDimensions; column++)
            {
                for (int row = 0; row <= ArrayDimensions - HourglassDimensions; row++)
                {
                    long hourglassSum =
                        GetRowSum(grid, column, row) // Top row of hourglass from this position
                        + grid[row + 1][column + 1] // Middle row of hourglass from this position
                        + GetRowSum(grid, column, row + 2);

                    if (maximalSum == null || hourglassSum > maximalSum)
                    {
                        maximalSum = hourglassSum;
                    }
                }
            }

            return maximalSum ?? 0;
        }

        long GetRowSum(long[][] grid, int column, int row)
        {
            long sum = 0;
            for(int i = 0; i < HourglassDimensions; i++)
            {
                sum += grid[row][column + i];
            }
            return sum;
        }
    }
}
