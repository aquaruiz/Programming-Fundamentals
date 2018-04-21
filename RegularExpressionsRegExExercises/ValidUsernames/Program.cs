using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" \\/()".ToCharArray());
            string pattern = @"^([a-zA-Z]\w{2,24})$";

            List<string> output = new List<string>();

            foreach (var word in input)
            {
                Match match = Regex.Match(word, pattern);

                if (match.Success)
                {
                    output.Add(match.Value);
                }
            }

            int currentLength = 0;
            int maxLength = 0;
            int foundAtIndex = 0;

            for (int i = 0; i < output.Count - 1; i++)
            {
                currentLength = output[i].Length + output[i + 1].Length;

                if (currentLength > maxLength)
                {
                    maxLength = currentLength;
                    foundAtIndex = i;
                }
            }

            Console.WriteLine(output[foundAtIndex]);
            Console.WriteLine(output[foundAtIndex + 1]);
        }
    }
}
