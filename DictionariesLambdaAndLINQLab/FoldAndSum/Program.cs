using System;
using System.Collections.Generic;
using System.Linq;

namespace FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            List<int> upperList = new List<int>();
            List<int> lowerList = new List<int>();
            List<int> output = new List<int>();

            upperList.AddRange(input.Take(input.Length / 4).Reverse().ToArray());
            upperList.AddRange(input.Skip(input.Length / 4 * 3).Take(input.Length / 4).Reverse().ToArray());

            lowerList.AddRange(input.Skip(input.Length / 4).Take(input.Length / 4 * 2).ToArray());

            for (int i = 0; i < lowerList.Count; i++)
            {
                output.Add(lowerList[i] + upperList[i]);
            }

            Console.WriteLine(string.Join(" ", output));
        }
    }
}
