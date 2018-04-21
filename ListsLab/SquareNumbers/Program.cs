using System;
using System.Collections.Generic;
using System.Linq;

namespace SquareNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> squaredNumbers = new List<int>();

            for (int i = 0; i < input.Count; i++)
            {
                if (Math.Sqrt(input[i]) == (int)Math.Sqrt(input[i]))
                {
                    squaredNumbers.Add(input[i]);
                }
            }

            squaredNumbers.Sort((a, b) => b.CompareTo(a));
            // sorting by descending

            Console.WriteLine(string.Join(" ", squaredNumbers));
        }
    }
}
