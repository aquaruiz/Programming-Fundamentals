using System;
using System.Linq;

namespace MaxSequenceIncreasingElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] collection = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int startIndex = 0;
            int length = 1;
            int bestIndex = 0;
            int bestLength = 1;

            for (int i = 1; i < collection.Length; i++)
            {
                if (collection[i] > collection[i - 1])
                {
                    startIndex = i - 1;
                    length++;
                }
                else
                {
                    startIndex = i;
                    length = 1;
                }

                if (length > bestLength)
                {
                    bestIndex = startIndex;
                    bestLength = length;
                }
            }

            for (int i = bestIndex + 1 - bestLength + 1; i <= bestIndex + 1; i++)
            {
                Console.Write(collection[i] + " ");
            }

            Console.WriteLine();
        }
    }
}