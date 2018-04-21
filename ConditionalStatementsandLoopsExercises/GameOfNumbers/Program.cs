using System;

namespace GameOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            int magicalNumber = int.Parse(Console.ReadLine());

            var firstLast = 0;
            var secondLast = 0;
            bool isTrue = false;

            var counter = 0;

            for (int i = numberOne; i <= numberTwo; i++)
            {
                for (int j = numberOne; j <= numberTwo; j++)
                {
                    counter++;
                    if (i + j == magicalNumber)
                    {
                        isTrue = true;
                        firstLast = i;
                        secondLast = j;
                    }
                }
            }

            if (isTrue)
            {
                Console.WriteLine($"Number found! {firstLast} + {secondLast} = {magicalNumber}");
            }
            else
            {
                Console.WriteLine($"{counter} combinations - neither equals {magicalNumber}");
            }


        }
    }
}
