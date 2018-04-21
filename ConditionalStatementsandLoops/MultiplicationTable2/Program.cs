using System;

namespace MultiplicationTable2
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var start = int.Parse(Console.ReadLine());

            if (start > 10)
            {
                Console.WriteLine($"{number} X {start} = {start * number}");
            }
            else
            {
                for (int i = start; i <= 10; i++)
                {
                    Console.WriteLine($"{number} X {i} = {number * i}");
                }
            }
        }
    }
}
