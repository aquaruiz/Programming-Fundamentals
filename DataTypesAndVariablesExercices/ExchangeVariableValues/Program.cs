using System;

namespace ExchangeVariableValues
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Before:\na = {0}\nb = {1}", a, b);
            int c = a;
            a = b;
            b = c;
            Console.WriteLine("After:\na = {0}\nb = {1}", a, b);
        }
    }
}
