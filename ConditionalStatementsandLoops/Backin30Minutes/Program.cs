using System;

namespace Backin30Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            var hours = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());

            var totalTimeInMinutes = hours * 60 + minutes;
            var after30Minutes = totalTimeInMinutes + 30;

            hours = after30Minutes / 60;
            minutes = after30Minutes % 60;

            if (hours > 23)
            {
                hours -= 24; 
            }

            Console.WriteLine($"{hours}:{minutes:d2}");
        }
    }
}
