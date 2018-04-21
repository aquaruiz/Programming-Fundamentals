using System;
using System.Collections.Generic;
using System.Linq;

namespace StuckZipper
{
    class Program
    {
        private static int smallestListCount;

        static void Main(string[] args)
        {
            List<int> input1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> input2 = Console.ReadLine().Split().Select(int.Parse).ToList();

            int min1 = Math.Abs(input1.Min());
            int min2 = Math.Abs(input2.Min());
            int smallestElement = min1 < min2 ? min1 : min2;
            int smallestElementDigits = smallestElement.ToString().Length;

            for (int i = 0; i < input1.Count; i++)
            {
                if (Math.Abs(input1[i]).ToString().Length > smallestElementDigits)
                {
                    input1.RemoveAt(i);
                    i--;
                }
            }

            for (int i = 0; i < input2.Count; i++)
            {
                if (Math.Abs(input2[i]).ToString().Length > smallestElementDigits)
                {
                    input2.RemoveAt(i);
                    i--;
                }
            }

            List<int> output = new List<int>();

            int smallerListCount = input1.Count < input2.Count ? input1.Count : input2.Count;

            for (int i = 0; i < smallerListCount; i++)
            {
                output.Add(input2[i]);
                output.Add(input1[i]);
            }

            if (input1.Count > input2.Count)
            {
                for (int i = smallerListCount; i < input1.Count; i++)
                {
                    output.Add(input1[i]);
                }
            }
            else if (input2.Count > input1.Count)
            {
                for (int i = smallerListCount; i < input2.Count; i++)
                {
                    output.Add(input2[i]);
                }
            }

            Console.WriteLine(string.Join(" ", output));
        }
    }
}
