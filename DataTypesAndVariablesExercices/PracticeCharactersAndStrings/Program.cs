using System;

namespace PracticeCharactersAndStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            var input1 = Console.ReadLine();
            var input2 = Console.ReadLine();
            var input3 = Console.ReadLine();
            var input4 = Console.ReadLine();
            var input5 = Console.ReadLine();

            try
            {
                char letter = char.Parse(input1);
                Console.WriteLine(letter);
            }
            catch
            {
                Console.WriteLine(input1);
            }

            try
            {
                char letter = char.Parse(input2);
                Console.WriteLine(letter);
            }
            catch
            {
                Console.WriteLine(input2);
            }

            try
            {
                char letter = char.Parse(input3);
                Console.WriteLine(letter);
            }
            catch
            {
                Console.WriteLine(input3);
            }

            try
            {
                char letter = char.Parse(input4);
                Console.WriteLine(letter);
            }
            catch
            {
                Console.WriteLine(input4);
            }

            try
            {
                char letter = char.Parse(input5);
                Console.WriteLine(letter);
            }
            catch
            {
                Console.WriteLine(input5);
            }
        }
    }
}
