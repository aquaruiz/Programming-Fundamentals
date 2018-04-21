using System;

namespace OddNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            while (number % 2 == 0)
            {
                Console.WriteLine("Please write an odd number.");
                number = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"The number is: {Math.Abs(number)}");
        }
    }
}
