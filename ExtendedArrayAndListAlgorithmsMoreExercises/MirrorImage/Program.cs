using System;
using System.Collections.Generic;
using System.Linq;

namespace MirrorImage
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            string command = Console.ReadLine();

            while (command != "Print")
            {
                int indexToShiftAround = int.Parse(command);
                string[] leftPart = new string[indexToShiftAround];
                string[] rightPart = new string[input.Length - 1 - indexToShiftAround];

                for (int i = 0; i < indexToShiftAround; i++)
                {
                    leftPart[i] = input[i];
                }

                int j = 0;
                for (int i = indexToShiftAround + 1; i < input.Length; i++)
                {
                    rightPart[j] = input[i];
                    j++;
                }

                leftPart = leftPart.Reverse().ToArray();
                rightPart = rightPart.Reverse().ToArray();

                List<string> helper = new List<string>();
                helper.AddRange(leftPart);
                helper.Add(input[indexToShiftAround]);
                helper.AddRange(rightPart);
                input = helper.ToArray();

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", input));
        }
    }
}
