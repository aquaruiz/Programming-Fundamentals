using System;

namespace MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());

            double poweredNumber = GivePower(number, power);
            Console.WriteLine(poweredNumber);
        }

        static double GivePower(double number, int power)
        {
            return Math.Pow(number, power);
        }
    }
}
