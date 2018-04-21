using System;

namespace CenturiesToMinutes
{
    class Program
    {
        static void Main(string[] args)
        {
            var centuries = int.Parse(Console.ReadLine());
            int years = 100 * centuries;
            int days = (int)(365.2422 * years);
            int hours = 24 * days;
            int minutes = 60 * hours;

            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");
        }
    }
}
