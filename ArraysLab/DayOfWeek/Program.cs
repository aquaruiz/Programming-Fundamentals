using System;

namespace DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] weekDays =
                {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};

            int day = int.Parse(Console.ReadLine());
            int dayindex = day - 1;
            if (dayindex >= 0 && dayindex <= 6)
            {
                Console.WriteLine(weekDays[dayindex]);
            }
            else
            {
                Console.WriteLine("Invalid Day!");
            }
        }
    }
}
