using System;
using System.Linq;

namespace CountSubstringOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            string wordToSearchFor = Console.ReadLine().ToLower();

            int counter = 0;
            int index = 0;

            while (true)
            {
                index = input.IndexOf(wordToSearchFor, index);
                
                if (index < 0)
                {
                    break;
                }
                else
                {
                    index++;
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }
    }
}
