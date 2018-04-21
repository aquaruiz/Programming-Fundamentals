using System;

namespace StringsAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            var var1 = Console.ReadLine();
            var var2 = Console.ReadLine();

            object obj = var1 + " " + var2;
            string var3 = (string)obj;
            Console.WriteLine(var3);
        }
    }
}
