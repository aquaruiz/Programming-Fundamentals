using System;
using System.Linq;

namespace Largest3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] output = input.OrderByDescending(x => x).Take(3).ToArray();

            Console.WriteLine(string.Join(" ", output));
        }
    }
}
