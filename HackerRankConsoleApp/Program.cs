using System;
using System.IO;

namespace HackerRankConsoleApp
{
    public class ValleyCounter
    {
        private const char Up = 'U';
        private const char Down = 'D';
        private const int SeaLevel = 0;

        public int CountValleys()
        {
            int numSteps = Convert.ToInt32(Console.ReadLine());
            string path = Console.ReadLine();

            int level = SeaLevel;
            int valleyCount = 0;

            foreach (char step in path)
            {
                if (step == Up)
                {
                    level++;
                }
                else if (step == Down)
                {
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

    class Program
    {
        private const string OutputPathName = "OUTPUT_PATH";

        static void Main(string[] args)
        {
            using (var output = new StreamWriter(Environment.GetEnvironmentVariable(OutputPathName), true))
            {
                var result = new ValleyCounter().CountValleys();
                output.WriteLine(result);
            }
        }
    }
}
