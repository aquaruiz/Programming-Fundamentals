using System;
using System.Numerics;

namespace FactorialTrailingZeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            BigInteger factorial = Factorial(n);
            BigInteger countZeros = CountTrailingZeros(factorial);
            Console.WriteLine(countZeros);
        }

        static BigInteger CountTrailingZeros(BigInteger factorial)
        {
            BigInteger countZeros = 0;

            while (factorial != 0)
            {
                BigInteger digit = factorial % 10;
                if (digit == 0)
                {
                    countZeros++;
                }
                else
                {
                    return countZeros;
                }

                factorial /= 10;
            }

            return countZeros;
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
