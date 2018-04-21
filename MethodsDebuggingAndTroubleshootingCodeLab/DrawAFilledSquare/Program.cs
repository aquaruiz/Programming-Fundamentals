using System;

namespace DrawAFilledSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            DrawSquare(n);
        }

        static void DrawSquare(int n)
        {
            PrintHeaderFooter(n);
            for (int i = 0; i < n - 2; i++)
            {
                PrintMiddleRow(n);
            }
            PrintHeaderFooter(n);
        }

        static void PrintMiddleRow(int n)
        {
            Console.Write('-');
            for (int i = 1; i < n; i++)
            {
                Console.Write("\\/");
            }
            Console.WriteLine('-');
        }

        static void PrintHeaderFooter(int n)
        {
            Console.WriteLine(new string('-', 2 * n));
        }
    }
}
