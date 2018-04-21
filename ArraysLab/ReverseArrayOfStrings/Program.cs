using System;

namespace ReverseArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] stringCollection = Console.ReadLine().Split();

            for (int i = 0; i < stringCollection.Length / 2; i++)
            {
                Swap(stringCollection,i);
            }

            Console.WriteLine(string.Join(" ", stringCollection));
        }

        static void Swap(string[] arr, int i)
        {
            string oldI = arr[i];
            arr[i] = arr[arr.Length - 1 - i];
            arr[arr.Length - 1 - i] = oldI;
        }
    }
}
