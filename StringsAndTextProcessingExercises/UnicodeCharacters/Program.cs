using System;

namespace UnicodeCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            foreach (char character in input)
            {
                Console.Write("\\u" + ((int)character).ToString("x4"));
            }
        }
    }
}
