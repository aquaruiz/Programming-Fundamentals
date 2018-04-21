using System;
using System.Collections.Generic;
using System.Linq;

namespace RemoveElementsAtOddPositions
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split().ToList();
            List<string> output = new List<string>();

            for (int i = 1; i <= input.Count; i++)
            {
                if (i % 2 == 0)
                {
                    output.Add(input[i - 1]);
                }
            }

            Console.WriteLine(string.Join("", output));
        }
    }
}
