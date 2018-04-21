using System;
using System.Linq;

namespace FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] collection = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] upperCollection = new int[collection.Length / 2];
            int[] lowerCollection = new int[collection.Length / 2];

            for (int i = 0; i < upperCollection.Length / 2; i++)
            {
                upperCollection[i] = collection[collection.Length / 2 / 2 - 1 - i];
            }

            int j = 0;

            for (int i = upperCollection.Length / 2; i < upperCollection.Length; i++)
            {
                upperCollection[i] = collection[collection.Length - 1 - j];
                j++;
            }

            for (int i = 0; i < lowerCollection.Length; i++)
            {
                lowerCollection[i] = collection[collection.Length / 2 / 2 + i];
            }

            int[] sumCollection = new int[upperCollection.Length];

            for (int i = 0; i < sumCollection.Length; i++)
            {
                sumCollection[i] = upperCollection[i] + lowerCollection[i];
            }

            Console.WriteLine(string.Join(" ", sumCollection));
        }
    }
}
