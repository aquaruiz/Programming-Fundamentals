using System;

namespace IndexLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alphabet = new char[(int)'z' - (int)'a' + 1];
            char letter = 'a';

            for (int i = 0; i < alphabet.Length; i++)
            {
                alphabet[i] = letter;
                letter++;
            }

            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < alphabet.Length; j++)
                {
                    if (input[i] == alphabet[j])
                    {
                        Console.WriteLine($"{input[i]} -> {j}");
                    }
                }
            }
        }
    }
}
