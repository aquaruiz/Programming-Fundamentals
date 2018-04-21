using System;

namespace Butterfly
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int row = 0; row < n - 2; row++)
            {
                if (row % 2 == 0)
                {
                    Console.WriteLine(new string('*', n - 2) + "\\ /" + new string('*', n - 2));
                }
                else
                {
                    Console.WriteLine(new string('-', n - 2) + "\\ /" + new string('-', n - 2));
                }
            }

            Console.WriteLine(new string(' ', n - 1) + "@" + new string(' ', n - 1));

            for (int row = 0; row < n - 2; row++)
            {
                if (row % 2 == 0)
                {
                    Console.WriteLine(new string('*', n - 2) + "/ \\" + new string('*', n - 2));
                }
                else
                {
                    Console.WriteLine(new string('-', n - 2) + "/ \\" + new string('-', n - 2));
                }
            }
        }
    }
}

