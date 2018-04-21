using System;

namespace HelloName
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            PrintName(name);
        }

        static void PrintName(string name)
        {
            Console.WriteLine("Hello, {0}!", name);
        }
    }
}
