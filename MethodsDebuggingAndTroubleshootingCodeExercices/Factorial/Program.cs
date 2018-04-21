using System;
using System.Numerics;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            BigInteger factorial = Factorial(n);
            Console.WriteLine(factorial);
        }

        static BigInteger Factorial(int n)
        {
            BigInteger factorial = 1;

            for (int i = 2; i <= n; i++)
            {
                factorial *= i;
            }

            return factorial;
        }
    }
}
