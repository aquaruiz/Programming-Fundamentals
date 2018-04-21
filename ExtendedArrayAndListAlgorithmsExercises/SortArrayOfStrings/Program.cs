using System;
using System.Collections.Generic;
using System.Linq;

namespace SortArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            List<string> sortedInput = input.ToList();
            sortedInput.Sort();
            input = sortedInput.ToArray();

            Console.WriteLine(string.Join(" ", input));
        }
    }
}
