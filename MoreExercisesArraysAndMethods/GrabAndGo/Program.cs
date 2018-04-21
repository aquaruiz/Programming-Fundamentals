using System;
using System.Linq;

namespace GrabAndGo
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] input = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long number = long.Parse(Console.ReadLine());

            long index = -1;

            for (long i = 0; i < input.Length; i++)
            {
                if (input[i] == number)
                {
                    index = i;
                }
            }

            if (index == -1)
            {
                Console.WriteLine("No occurrences were found!");
            }
            else
            {
                long sum = 0;

                for (long i = 0; i < index; i++)
                {
                    sum += input[i];
                }

                Console.WriteLine(sum);
            }
        }
    }
}
