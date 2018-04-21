using System;

namespace TextFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine().Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            string input = Console.ReadLine();

            foreach (var word in bannedWords)
            {
                input = input.Replace(word, new string('*', word.Length));
            }

            Console.WriteLine(input);
        }
    }
}
