using System;
using System.Collections.Generic;
using System.Linq;

namespace LettersChangeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToArray();
            double sum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                string numberBetweenTwoLetters = input[i];
                char firstLetter = numberBetweenTwoLetters[0];
                char lastLetter = numberBetweenTwoLetters[numberBetweenTwoLetters.Length - 1];
                List<char> current = numberBetweenTwoLetters.ToList();
                current.RemoveAt(current.Count - 1);
                current.RemoveAt(0);

                double number = double.Parse(string.Join("", current));

                if (firstLetter >= 'A' && firstLetter <= 'Z')
                {
                    number = number / ((int)firstLetter - 64);
                }
                else if (firstLetter >= 'a' && firstLetter <= 'z')
                {
                    number *= (int)firstLetter - 96;
                }

                if (lastLetter >= 'A' && lastLetter <= 'Z')
                {
                    number -= ((int)lastLetter - 64);
                }
                else if (lastLetter >= 'a' && lastLetter <= 'z')
                {
                    number += (int)lastLetter - 96;
                }

                sum += number;
            }

            Console.WriteLine($"{sum:0.00}");
        }
    }
}
