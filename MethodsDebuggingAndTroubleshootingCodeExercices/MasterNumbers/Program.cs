using System;

namespace MasterNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int endNumber = int.Parse(Console.ReadLine());

            for (int i = 1; i <= endNumber; i++)
            {
                if (IsPalindrome(i) && SumOfDigitsDivisibleBy7(i) && ContainsEvenDigit(i))
                {
                    Console.WriteLine(i);
                }
            }

        }

        static bool ContainsEvenDigit(int number)
        {
            bool isEvenDigit = false;
            while (number != 0)
            {
                int digit = number % 10;
                if (digit % 2 == 0)
                {
                    isEvenDigit = true;
                }
                number /= 10;
            }

            return isEvenDigit;
        }

        static bool SumOfDigitsDivisibleBy7(int number)
        {
            bool isDevisibleBy7 = false;
            int sum = 0;

            while (number != 0)
            {
                int digit = number % 10;
                sum += digit;
                number /= 10;
            }

            if (sum % 7 == 0)
            {
                isDevisibleBy7 = true;
            }

            return isDevisibleBy7;
        }

        static bool IsPalindrome(int number)
        {            
            string checkedNumber = number.ToString();

            for (int i = 0; i < checkedNumber.Length; i++)
            {
                if (checkedNumber[i] != checkedNumber[checkedNumber.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
