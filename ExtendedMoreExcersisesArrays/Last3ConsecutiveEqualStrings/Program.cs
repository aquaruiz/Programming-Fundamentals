using System;
using System.Linq;

namespace Last3ConsecutiveEqualStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();
            int index = 0;

            for (int i = 2; i < input.Length; i++)
            {
                if (input[i] == input[i - 1] && input[i - 1] == input[i - 2])
                {
                    index = i - 2;
                }
            }

            Console.WriteLine(new string('0', 3).Replace("0", input[index] + " "));
        }
    }
}
