using System;

namespace ReverseAnArrayOfIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int[] arr = new int[count];

            for (int i = 0; i < count; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < arr.Length / 2; i++)
            {
                SwapElements(arr, i, (arr.Length - 1) - i);
            }

            Console.WriteLine(string.Join(" ", arr));
        }

        static void SwapElements(int[] arr, int i, int j)
        {
            int oldElemenet = arr[i];
            arr[i] = arr[j];
            arr[j] = oldElemenet;
        }
    }
}
