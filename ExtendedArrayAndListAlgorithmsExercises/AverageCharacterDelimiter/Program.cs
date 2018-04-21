using System;

namespace AverageCharacterDelimiter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int avSum;
            char avChar;

            int sumAsciiCodes = 0;
            int countLetters = 0;

            foreach (var word in input)
            {
                foreach (var letter in word)
                {
                    sumAsciiCodes += (int)letter;
                    countLetters++;
                }
            }

            avSum = (int)(sumAsciiCodes / (double)countLetters);
            avChar = (char)avSum;

            if (avChar >= 97 && avChar <= 122)
            {
                avChar = (char)((int)avChar - 32);
            }

            string delimiter = avChar.ToString();
            Console.WriteLine(string.Join(delimiter, input));
        }
    }
}
