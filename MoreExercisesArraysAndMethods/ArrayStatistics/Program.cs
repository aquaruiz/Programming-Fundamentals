using System;
using System.Linq;

namespace ArrayStatistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Console.WriteLine("Min = {0}", input.Min());
            Console.WriteLine("Max = {0}", input.Max());
            Console.WriteLine("Sum = {0}", input.Sum());
            Console.WriteLine("Average = {0}", input.Average());
        }
    }
}
