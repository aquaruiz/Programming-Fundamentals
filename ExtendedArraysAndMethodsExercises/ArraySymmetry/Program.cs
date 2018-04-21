using System;
using System.Linq;

namespace CountNegativeElementsInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split().ToArray();

            for (int i = 0; i < arr.Length / 2; i++)
            {
                if (arr[i] == arr[arr.Length - 1 - i])
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
