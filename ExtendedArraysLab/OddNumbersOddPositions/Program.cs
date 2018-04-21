using System;
using System.Linq;

namespace OddNumbersOddPositions
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < input.Length; i++)
            {
                if (i % 2 == 1 && Math.Abs(input[i] % 2) == 1)
                {
                    Console.WriteLine($"Index {i} -> {input[i]}");
                }
            }
        }
    }
}
