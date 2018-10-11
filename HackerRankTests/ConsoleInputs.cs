using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace HackerRankTests
{
    public class ConsoleInputs : IDisposable
    {
        private readonly TextReader consoleIn;

        public ConsoleInputs(params object[] inputs)
        {
            consoleIn = Console.In;
            string inputString = string.Join(Environment.NewLine, inputs);
            Console.SetIn(new StringReader(inputString));
        }

        public void Dispose()
        {
            Console.SetIn(consoleIn);
        }
    }
}
