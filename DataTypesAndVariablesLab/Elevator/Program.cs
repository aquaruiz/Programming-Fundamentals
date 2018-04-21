using System;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = int.Parse(Console.ReadLine());
            var capacity = int.Parse(Console.ReadLine());

            var courses = 0;

            while (people > 0)
            {
                people -= capacity;
                courses++;
            }

            Console.WriteLine(courses);
        }
    }
}
