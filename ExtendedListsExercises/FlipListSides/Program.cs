using System;
using System.Collections.Generic;
using System.Linq;

namespace FlipListSides
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> leftHalf = new List<int>();
            int leftHalfCount = 0;
            int middleIndex = 0;

            if (input.Count % 2 == 1)
            {
                leftHalfCount = (input.Count - 3) / 2;
                middleIndex = input.Count / 2 + 1;
            }
            else
            {
                leftHalfCount = (input.Count - 2) / 2;
                middleIndex = input.Count / 2;
            }

            for (int i = 1; i < 1 + leftHalfCount; i++)
            {
                leftHalf.Add(input[i]);
                input[i] = input[input.Count - 1 - i];
            }

            int j = leftHalf.Count - 1;

            for (int i = middleIndex; i < input.Count - 1; i++)
            {
                input[i] = leftHalf[j];
                j--;
            }

            Console.WriteLine(string.Join(" ", input));
        }
    }
}
