using System;
using System.Linq;

namespace CountNegativeElementsInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] arr = Console.ReadLine().Split().Select(double.Parse).ToArray();
            double number = double.Parse(Console.ReadLine());

            Console.WriteLine(arr.Count(s => s > number));
        }
    }
}
