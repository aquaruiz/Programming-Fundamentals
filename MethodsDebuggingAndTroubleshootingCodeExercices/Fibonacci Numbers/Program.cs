using System;

namespace FibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int number = Fib(n);

            Console.WriteLine(number);
        }

        static int Fib(int n)
        {
            int firstNumber = 1;
            int nextNumber = 1;
            int lastNumber = 1;

            for (int i = 2; i <= n; i++)
            {
                lastNumber = firstNumber + nextNumber;
                firstNumber = nextNumber;
                nextNumber = lastNumber;
            }
            return lastNumber;
        }
    }
}
