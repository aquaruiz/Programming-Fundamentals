using System;
using System.Collections.Generic;
using System.Linq;

namespace SearchForANumber
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] commands = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int elementsToTakeQnty = commands[0];
            int elementsToDeleteQnty = commands[1];
            int numberToSearch = commands[2];

            List<int> newInput = new List<int>();

            for (int i = 0; i < elementsToTakeQnty; i++)
            {
                newInput.Add(input[i]);
            }

            for (int i = elementsToDeleteQnty; i > 0; i--)
            {
                newInput.RemoveAt(i - 1);
            }

            if (newInput.Contains(numberToSearch))
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}
