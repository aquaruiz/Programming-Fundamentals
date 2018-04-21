using System;
using System.Linq;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string output = string.Join("", input.Reverse());

            Console.WriteLine(output);
        }
    }
}
