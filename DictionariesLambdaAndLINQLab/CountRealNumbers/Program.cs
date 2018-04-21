using System;
using System.Collections.Generic;
using System.Linq;

namespace CountRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] input = Console.ReadLine().Split().Select(double.Parse).ToArray();

            SortedDictionary<double, int> count = new SortedDictionary<double, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (!count.ContainsKey(input[i]))
                {
                    count.Add(input[i], 1);
                }
                else
                {
                    count[input[i]]++;
                }
            }

            foreach (var kvp in count)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
