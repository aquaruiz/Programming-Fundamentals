using System;

namespace ChristmasTree
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int row = 0; row < n + 1; row++)
            {
                for (int col = 0; col < n - row; col++)
                {
                    Console.Write(" ");
                }

                Console.Write(new string('*', row));
                Console.Write(" | ");
                Console.Write(new string('*', row));

                for (int col = 0; col < n - row + 1; col++)
                {
                    Console.Write(" ");
                }

                Console.WriteLine();
            }
        }
    }
}
