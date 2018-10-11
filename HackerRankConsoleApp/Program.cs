﻿using System;
using System.IO;

namespace HackerRankConsoleApp
{
    public class CharacterACounter
    {
        private const char a = 'a';

        public long CountCharacterA()
        {
            string str = Console.ReadLine();
            long substringLength = Convert.ToInt64(Console.ReadLine());

            long characterACount = 0;
            if (substringLength > str.Length)
            {
                for (int i = 0; i < str.Length; i++)
                {
                    char c = str[i];
                    if (c == a)
                    {
                        characterACount++;
                    }
                }

                characterACount *= substringLength / str.Length;

                long remainder = substringLength % str.Length;

                for (int i = 0; i < remainder; i++)
                {
                    char c = str[i];
                    if (c == a)
                    {
                        characterACount++;
                    }
                }
            }
            else
            {
                for (int i = 0; i < substringLength; i++)
                {
                    char c = str[i];
                    if (c == a)
                    {
                        characterACount++;
                    }
                }
            }

            return characterACount;
        }
    }

    class Program
    {
        private const string OutputPathName = "OUTPUT_PATH";

        static void Main(string[] args)
        {
            using (var output = new StreamWriter(Environment.GetEnvironmentVariable(OutputPathName), true))
            {
                var result = new CharacterACounter().CountCharacterA();
                output.WriteLine(result);
            }
        }
    }
}
