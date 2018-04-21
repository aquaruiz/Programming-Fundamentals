using System;
using System.Collections.Generic;
using System.Linq;

namespace DecodeRadioFrequencies
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();
            List<char> wordLeftPart = new List<char>();
            List<char> wordRightPart = new List<char>();
            List<char> word = new List<char>();

            for (int i = 0; i < input.Length; i++)
            {
                int[] numbers = input[i].ToString().Split('.').Select(int.Parse).ToArray();

                char leftPart;
                char rightPart;

                if (numbers[0] != 0)
                {
                    leftPart = (char)numbers[0];
                    wordLeftPart.Add(leftPart);

                }

                if (numbers[1] != 0)
                {
                    rightPart = (char)numbers[1];
                    wordRightPart.Add(rightPart);
                }
            }
            
            word.AddRange(wordLeftPart);
            wordRightPart.Reverse();
            word.AddRange(wordRightPart);

            Console.WriteLine(string.Join("", word));
        }
    }
}
