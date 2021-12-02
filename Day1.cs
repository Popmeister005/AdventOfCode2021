using System;
using static Utilities;

namespace Day1
{
    class Day1
    {
        static void Main(string[] args)
        {
            //string[] lines = ReadPuzzleInput("TestInput.txt");
            string[] lines = ReadPuzzleInput("PuzzleInput.txt");

            int increaseCount = 0;
            int previousDepth = 0;
            int slidingcount = 0;

            for(int i = 0; i < (lines.Length-2); i++)
            {
                slidingcount++;

                int currentDepth = Int16.Parse(lines[i]) + Int16.Parse(lines[i + 1]) + Int16.Parse(lines[i + 2]);

                if (currentDepth > previousDepth)
                    {
                    increaseCount++;
                    }

                previousDepth = currentDepth;
            }

            Console.WriteLine(increaseCount - 1);
        }
    }
}
