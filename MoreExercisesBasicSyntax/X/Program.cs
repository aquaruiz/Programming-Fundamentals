using System;

namespace X
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int j = n - 2;
            int i = 0;
            for (i = 0; i < n / 2; i++)
            {
                Console.Write(new string(' ', i));
                Console.Write("x");
                Console.Write(new string(' ', j));
                Console.WriteLine("x");
                j -= 2;
            }

            Console.WriteLine(new string(' ', i) + "x");

            for (i = n / 2 - 1; i >= 0; i--)
            {
                j += 2;
                Console.Write(new string(' ', i));
                Console.Write("x");
                Console.Write(new string(' ', j));
                Console.WriteLine("x");                
            }
        }
    }
}
