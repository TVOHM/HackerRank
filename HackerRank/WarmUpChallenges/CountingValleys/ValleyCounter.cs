using System;

namespace HackerRank.WarmUpChallenges.CountingValleys
{
    public class ValleyCounter
    {
        private const char Up = 'U';
        private const char Down = 'D';
        private const int SeaLevel = 0;

        public long CountValleys()
        {
            int numSteps = Convert.ToInt32(Console.ReadLine());
            string path = Console.ReadLine();

            long level = SeaLevel;
            long valleyCount = 0;

            foreach(char step in path)
            {
                if (step == Up)
                {
                    level++;
                }
                else if (step == Down)
                {
                    // If we've moved down from sea level, we've stepped into a new valley.
                    if (level == SeaLevel)
                    {
                        valleyCount++;
                    }
                    level--;
                }
            }

            return valleyCount;
        }
    }
}
