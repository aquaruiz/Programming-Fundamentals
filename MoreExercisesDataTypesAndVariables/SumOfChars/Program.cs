using System;

namespace SumOfChars
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < number; i++)
            {
                char character = char.Parse(Console.ReadLine());
                sum += (int)character;
            }
            Console.WriteLine("The sum equals: {0}", sum);
        }
    }
}