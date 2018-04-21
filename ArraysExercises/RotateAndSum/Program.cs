using System;
using System.Linq;

namespace RotateAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] collection = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rotateCount = int.Parse(Console.ReadLine());

            int[] sumCollection = new int[collection.Length];

            for (int i = 0; i < rotateCount; i++)
            {
                collection = SwapArray(collection);

                for (int j = 0; j < collection.Length; j++)
                {
                    sumCollection[j] += collection[j];
                }
            }

            Console.WriteLine(string.Join(" ", sumCollection));
        }

        static int[] SwapArray(int[] array)
        {
            int[] swapedArray = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                swapedArray[(i + 1) % array.Length] = array[i];
            }

            return swapedArray;
        }
    }
}
