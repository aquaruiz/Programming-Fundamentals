using System;
using System.Collections.Generic;
using System.Linq;

namespace CountNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
            input.Sort();

            int [] numbersPositions = new int[1000];
            int count = 1;

            for (int i = 1; i < input.Count; i++)
            {
                if (input[i - 1] == input[i])
                {
                    count++;
                }
                else
                {
                    numbersPositions[input[i - 1]] = count;
                    count = 1;
                }
            }

            numbersPositions[input[input.Count - 1]] = count;

            for (int i = 0; i < numbersPositions.Length; i++)
            {
                if (numbersPositions[i] != 0)
                {
                    Console.WriteLine($"{i} -> {numbersPositions[i]}");
                }
            }
        }
    }
}
