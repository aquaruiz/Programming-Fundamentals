using System;

namespace PrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());

            bool isPrime = IsPrime(number);
            Console.WriteLine(isPrime);
        }

        static bool IsPrime(long number)
        {
            bool isPrime = true;

            if (number < 2)
            {
                isPrime = false;
            }

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                }
            }

            return isPrime;
        }
    }
}
