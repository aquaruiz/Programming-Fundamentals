using System;

namespace NumberChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());

            if (number % 1 == 0)
            {
                Console.WriteLine("integer");
            }
            else
            {
                Console.WriteLine("floating-point");
            }
        }
    }
}
