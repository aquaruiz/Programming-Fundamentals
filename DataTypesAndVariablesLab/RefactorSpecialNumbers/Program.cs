using System;

namespace RefactorSpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= number; i++)
            {
                int sum = 0;
                int current = i;
                bool isSpecial = false;
                while (current > 0)
                {
                    sum += current % 10;
                    current = current / 10;
                }
                isSpecial = ((sum == 5) || (sum == 7) || (sum == 11));
                Console.WriteLine($"{i} -> {isSpecial}");
            }
        }
    }
}
