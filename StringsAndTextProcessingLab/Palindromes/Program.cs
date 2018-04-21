using System;
using System.Collections.Generic;
using System.Linq;

namespace Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ,.?!".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            List<string> output = new List<string>();

            foreach (var word in input)
            {
                string firstHalf;
                string secondHalf;

                if (word.Length == 1)
                {
                    firstHalf = word;
                    secondHalf = word;
                }
                else if (word.Length % 2 == 0)
                {
                    firstHalf = word.Substring(0, word.Length / 2);
                    secondHalf = string.Join("", word.Substring(word.Length / 2).Reverse());
                }
                else
                {
                    firstHalf = word.Substring(0, word.Length / 2);
                    secondHalf = string.Join("", (word.Substring((word.Length / 2) + 1)).Reverse());
                }

                if (firstHalf == secondHalf && !output.Contains(word))
                {
                    output.Add(word);
                }
            }

            output.Sort();

            Console.WriteLine(string.Join(", ", output));
        }
    }
}
