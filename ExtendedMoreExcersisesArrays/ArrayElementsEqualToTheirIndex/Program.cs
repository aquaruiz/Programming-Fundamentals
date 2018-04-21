using System;
using System.Linq;

namespace ArrayElementsEqualToTheirIndex
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < input.Length; i++)
            {
                if (i == input[i])
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
