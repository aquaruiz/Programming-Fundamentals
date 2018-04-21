using System;
using System.Linq;

namespace PairsByDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] collection = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int difference = int.Parse(Console.ReadLine());

            int counter = 0; ;

            for (int i = 0; i < collection.Length; i++)
            {
                for (int j = i; j < collection.Length; j++)
                {
                    if (Math.Abs(collection[i] - collection[j]) == Math.Abs(difference) && i != j)
                    {
                        counter++;
                    }
                }
            }

            Console.WriteLine(counter);
        }
    }
}
