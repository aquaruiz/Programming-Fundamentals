using System;

namespace TheatrePromotions
{
    class Program
    {
        static void Main(string[] args)
        {
            var dayType = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());

            if (age < 0 || age > 122)
            {
                Console.WriteLine("Error!");
            }
            else
            {
                if (dayType == "Weekday" && age > 18 && age <= 64)
                {
                    Console.WriteLine("18$");
                }
                else if (dayType == "Weekday" && (age <= 18 || age > 64))
                {
                    Console.WriteLine("12$");
                }
                else if (dayType == "Weekend" && age > 18 && age <= 64)
                {
                    Console.WriteLine("20$");
                }
                else if (dayType == "Weekend" && (age <= 18 || age > 64))
                {
                    Console.WriteLine("15$");
                }
                else if (dayType == "Holiday" && age > 18 && age <= 64)
                {
                    Console.WriteLine("12$");
                }
                else if (dayType == "Holiday" && age <= 18)
                {
                    Console.WriteLine("5$");
                }
                else if (dayType == "Holiday" && age > 64)
                {
                    Console.WriteLine("10$");
                }
            }
        }
    }
}
