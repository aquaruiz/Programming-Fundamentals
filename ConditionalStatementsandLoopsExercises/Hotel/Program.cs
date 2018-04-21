using System;

namespace Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nightsCount = int.Parse(Console.ReadLine());

            double studioPrice = 0.0;
            double doublePrice = 0.0;
            double suitePrice = 0.0;

            if (month == "May" || month == "October")
            {
                studioPrice = 50;
                doublePrice = 65;
                suitePrice = 75;
            }
            else if (month == "June" || month == "September")
            {
                studioPrice = 60;
                doublePrice = 72;
                suitePrice = 82;
            }
            else if (month == "July" || month == "August" || month == "December")
            {
                studioPrice = 68;
                doublePrice = 77;
                suitePrice = 89;
            }

            if ((month == "May" || month == "October") && nightsCount > 7)
            {
                studioPrice *= 0.95;
            }

            if ((month == "June" || month == "September") && nightsCount > 14)
            {
                doublePrice *= 0.9;
            }

            if ((month == "July" || month == "August" || month == "December") && nightsCount > 14)
            {
                suitePrice *= 0.85;
            }

            if ((month == "October" || month == "September") && nightsCount > 7)
            {
                studioPrice *= ((nightsCount - 1) / (double)nightsCount);
            }

            Console.WriteLine($"Studio: {studioPrice*nightsCount:f2} lv.");
            Console.WriteLine($"Double: {doublePrice * nightsCount:f2} lv.");
            Console.WriteLine($"Suite: {suitePrice * nightsCount:f2} lv.");
        }
    }
}
