using System;
using System.Collections.Generic;
using System.Linq;

namespace MaxSequenceEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();

            int counter = 1;
            int numberIndex = 0;
            int bestCount = 0;
            int bestIndex = 0;

            for (int i = 1; i < input.Count; i++)
            {
                if (input[i - 1] == input[i])
                {
                    counter++;
                    numberIndex = i;
                }
                else
                {
                    if (counter > bestCount)
                    {
                        bestCount = counter;
                        bestIndex = numberIndex;
                    }

                    counter = 1;
                    numberIndex = 0;
                }
            }

            if (counter > bestCount)
            {
                bestCount = counter;
                bestIndex = numberIndex;
            }

            Console.WriteLine(new string('1', bestCount).Replace("1", $"{input[bestIndex] + " "}"));
        }
    }
}
