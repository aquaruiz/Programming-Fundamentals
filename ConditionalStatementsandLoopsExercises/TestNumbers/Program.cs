using System;

namespace TestNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            int magicalNumber = int.Parse(Console.ReadLine());

            var totalSum = 0;
            var counter = 0;

            for (int i = numberOne; i >= 1; i--)
            {
                for (int j = 1; j <= numberTwo; j++)
                {
                    totalSum += i * j * 3;
                    counter++;
                    if (totalSum >= magicalNumber)
                    {
                        Console.WriteLine($"{counter} combinations");
                        Console.WriteLine($"Sum: {totalSum} >= {magicalNumber}");
                        return;
                    }
                }
            }

            Console.WriteLine($"{counter} combinations");
            Console.WriteLine($"Sum: {totalSum}");
            
        }
    }
}
