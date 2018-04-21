using System;

namespace Add_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var c = a + b;

            Console.WriteLine($"{a} + {b} = {c}");
        }
    }
}
