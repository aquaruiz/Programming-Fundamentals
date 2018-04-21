using System;

namespace TemperatureConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            double fahrenheit = double.Parse(Console.ReadLine());

            double celsius = ConvertToCelsius(fahrenheit);
            Console.WriteLine("{0:0.00}", celsius);
        }

        static double ConvertToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }
    }
}
