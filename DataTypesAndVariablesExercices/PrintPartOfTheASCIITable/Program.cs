using System;

namespace PrintPartOfTheASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {
            var start = int.Parse(Console.ReadLine());
            var stop = int.Parse(Console.ReadLine());

            for (int i = start; i <= stop; i++)
            {
                Console.Write($"{(char)i} ");
            }
        }
    }
}
