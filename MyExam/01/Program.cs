using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            long studentsQnty = long.Parse(Console.ReadLine());
            double pricePerLightsaber = double.Parse(Console.ReadLine());
            double pricePerRode = double.Parse(Console.ReadLine());
            double pricePerSingleBelt = double.Parse(Console.ReadLine());

            long lightsaberQnty = (long)Math.Ceiling(studentsQnty * 1.1);
            long rodeQnty = studentsQnty;
            long singleBeltQnty = studentsQnty - studentsQnty / 6;

            double totalPrice = pricePerLightsaber * lightsaberQnty + pricePerRode * rodeQnty + pricePerSingleBelt * singleBeltQnty;

            if (totalPrice <= budget)
            {
                Console.WriteLine($"The money is enough - it would cost {totalPrice:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {totalPrice - budget:f2}lv more.");
            }
        }
    }
}
