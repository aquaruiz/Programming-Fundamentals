using System;
using System.Collections.Generic;

namespace MorseCodeUpgraded
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split('|');
            List<char> output = new List<char>();

            int sum = 0;
            int lenghtOfSequence = 1;

            for (int i = 0; i < input.Length; i++)
            {
                string letter = input[i];

                for (int j = 0; j < letter.Length; j++)
                {
                    if (int.Parse(letter[j].ToString()) == 0)
                    {
                        sum += 3;
                    }

                    if (int.Parse(letter[j].ToString()) == 1)
                    {
                        sum += 5;
                    }
                }

                int index = 0;

                while (index < letter.Length - 1)
                {

                    if (letter[index] == letter[index + 1])
                    {
                        lenghtOfSequence++;
                        index++;
                    }
                    else
                    {
                        if (lenghtOfSequence > 1)
                        {
                            sum += lenghtOfSequence;
                        }

                        index++;
                        lenghtOfSequence = 1;
                    }
                }

                if (index >= letter.Length - 1 && lenghtOfSequence > 1)
                {
                    sum += lenghtOfSequence;
                    lenghtOfSequence = 1;
                }

                output.Add((char)sum);
                sum = 0;
            }

            Console.WriteLine(string.Join("", output));
        }
    }
}
