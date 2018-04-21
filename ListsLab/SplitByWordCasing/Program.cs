using System;
using System.Collections.Generic;
using System.Linq;

namespace SplitByWordCasing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(",;:.!()\"\'\\/[] ".ToCharArray()).ToList();

            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] == "")
                {
                    input.RemoveAt(i);
                    i--;
                }
            }

            List<string> upperCases = new List<string>();
            List<string> lowerCases = new List<string>();
            List<string> mixedCases = new List<string>();

            int upperLetters = 0;
            int lowerLetters = 0;
            int elseSymbols = 0;

            for (int i = 0; i < input.Count; i++)
            {
                foreach (char letter in input[i])
                {
                    if ('a' <= letter && letter <= 'z')
                    {
                        lowerLetters++;
                    }
                    else if ('A' <= letter && letter <= 'Z')
                    {
                        upperLetters++;
                    }
                    else
                    {
                        elseSymbols++;
                    }
                }

                if (elseSymbols > 0)
                {
                    mixedCases.Add(input[i]);
                }
                else if (upperLetters == 0)
                {
                    lowerCases.Add(input[i]);
                }
                else if (lowerLetters == 0)
                {
                    upperCases.Add(input[i]);
                }
                else
                {
                    mixedCases.Add(input[i]);
                }

                lowerLetters = 0;
                upperLetters = 0;
                elseSymbols = 0;
            }

            Console.WriteLine("Lower-case: " + string.Join(", ", lowerCases));
            Console.WriteLine("Mixed-case: " + string.Join(", ", mixedCases));
            Console.WriteLine("Upper-case: " + string.Join(", ", upperCases));
        }
    }
}
