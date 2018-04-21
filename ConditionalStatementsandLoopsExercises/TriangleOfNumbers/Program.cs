using System;

namespace TriangleOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine(new string('#', i).Replace("#", i.ToString() + " "));
            }
        }
    }
}
