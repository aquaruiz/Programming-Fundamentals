using System;

namespace NumbersInReversedOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal number = decimal.Parse(Console.ReadLine());
            var reversedNumber = 0.0;


            if (number % 1 == 0)
            {
                int wholePart = (int)number;
                reversedNumber = ReverseNumber(wholePart);
            }
            else
            {
                int wholePart = (int)number;
                decimal fractionalPart = (decimal)number % 1m;
                double fractionPartLength = fractionalPart.ToString().Length - 1;
                int pow = (int)Math.Pow(10.0, fractionPartLength);
                int fractionalWholePart = (int)(fractionalPart * pow);

                int reversedFractionalPart = ReverseNumber(fractionalWholePart);
                int reversedWholePart = ReverseNumber(wholePart);
                double newFractalPart = reversedWholePart / Math.Pow(10, wholePart.ToString().Length);
                int newWholePart = reversedFractionalPart;
                reversedNumber = newWholePart + newFractalPart;
            }
            Console.WriteLine(reversedNumber);
        }

        static int ReverseNumber(int number)
        {
            int reversedNumber = 0;
            int pow = number.ToString().Length - 1;
            while (number > 0)
            {
                int digit = number % 10;
                reversedNumber += digit * (int)Math.Pow(10, pow);
                pow--;
                number /= 10;
            }
            return reversedNumber;
        }
    }
}
