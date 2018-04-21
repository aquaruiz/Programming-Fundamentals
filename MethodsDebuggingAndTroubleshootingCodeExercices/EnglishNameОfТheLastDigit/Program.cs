using System;

namespace EnglishNameОfТheLastDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            string digitName = GiveLastDigitName(number);

            Console.WriteLine(digitName);
        }

        static string GiveLastDigitName(long number)
        {
            int digit = Math.Abs((int)(number % 10));

            switch (digit)
            {
                case 1: return "one";                   
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";
                default: return "zero";
            } 
        }
    }
}
