using System;

namespace SignOfIntegerNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintSign(n);
        }

        static void PrintSign(int n)
        {
            string sign = "";
            if (n == 0)
            {
                sign = "zero";
            }
            else if(n > 0)
            {
                sign = "positive";
            }
            else
            {
                sign = "negative";
            }

            Console.WriteLine($"The number {n} is {sign}.");
        }
    }
}
