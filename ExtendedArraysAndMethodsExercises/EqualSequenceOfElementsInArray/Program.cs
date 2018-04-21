using System;
using System.Linq;

namespace IncreasingSequenceOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i - 1] == arr[i])
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("No");
                    return;
                }
            }

            Console.WriteLine("Yes");
        }
    }
}
