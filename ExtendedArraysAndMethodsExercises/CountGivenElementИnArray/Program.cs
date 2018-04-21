using System;
using System.Linq;

namespace CountNegativeElementsInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(arr.Count(s => s == number));
        }
    }
}
