using System;

namespace _ReverseCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string letter1 = Console.ReadLine();
            string letter2 = Console.ReadLine();
            string letter3 = Console.ReadLine();

            string output = letter3 + letter2 + letter1;

            Console.WriteLine(output);
        }
    }
}
