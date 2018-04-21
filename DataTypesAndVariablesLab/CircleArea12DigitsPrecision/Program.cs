using System;

namespace CircleArea12DigitsPrecision
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius = double.Parse(Console.ReadLine());

            double area = Math.PI * radius * radius;

            Console.WriteLine("{0:f12}", area);
        }
    }
}
