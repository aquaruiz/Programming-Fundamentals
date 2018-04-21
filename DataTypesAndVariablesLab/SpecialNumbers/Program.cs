using System;

namespace SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                var sum = 0;
                bool isSpecial = false;
                var number = i;
                while (number > 0)
                {
                    sum += number % 10;
                    number /= 10;
                }
                if (sum == 5 || sum == 7 || sum == 11)
                {
                    isSpecial = true;
                }
                Console.WriteLine("{0} -> {1}", i , isSpecial);
            }
        }
    }
}
