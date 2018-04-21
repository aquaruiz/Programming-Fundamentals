using System;

namespace MilestoKilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            var miles = double.Parse(Console.ReadLine());
            var constant = 1.60934;
            var kilometers = miles * constant;

            Console.WriteLine($"{kilometers:f2}");
        }
    }
}
