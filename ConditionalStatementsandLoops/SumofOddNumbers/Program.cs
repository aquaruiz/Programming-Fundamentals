using System;

namespace SumofOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var oddNumberQnty = int.Parse(Console.ReadLine());

            var Number = 1;
            var sum = 0;
            for (int i = 0; i < oddNumberQnty; i++)
            {
                sum += Number;
                Console.WriteLine(Number);
                Number += 2;
            }
            Console.WriteLine("Sum: " + sum);
        }
    }
}
