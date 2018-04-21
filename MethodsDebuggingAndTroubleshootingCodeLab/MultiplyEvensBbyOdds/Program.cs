using System;

namespace MultiplyEvensBbyOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int multiplyProduct = GetMultipleOfEvensAndOdds(Math.Abs(number));
            Console.WriteLine(multiplyProduct);
        }

        static int GetMultipleOfEvensAndOdds(int number)
        {
            int sumEvens = GetSumOfEvenDigits(number);
            int sumOdds = GetSumOfOddDigits(number);
            return sumEvens * sumOdds;
        }

        static int GetSumOfOddDigits(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                int digit = number % 10;
                if (digit % 2 == 1)
                {
                    sum += digit;
                }

                number /= 10;
            }

            return sum;
        }

        static int GetSumOfEvenDigits(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                int digit = number % 10;
                if (digit % 2 == 0)
                {
                    sum += digit;
                }

                number /= 10;
            }

            return sum;
        }
    }
}
