using System;
using System.Collections.Generic;
using System.Linq;

namespace MagicExchangeableWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            List<char> firstString = input[0].ToCharArray().Distinct().ToList();
            List<char> secondString = input[1].ToCharArray().Distinct().ToList();

            bool areExchangeable = false;

            if (firstString.Count == secondString.Count)
            {
                areExchangeable = true;
            }

            Console.WriteLine(areExchangeable.ToString().ToLower());
        }
    }
}
