using System;
using System.Collections.Generic;
using System.Linq;

namespace RemoveNegativesAndReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> collection = Console.ReadLine().Split().Select(int.Parse).ToList();

            for (int i = 0; i < collection.Count; i++)
            {
                if (collection[i] < 0)
                {
                    collection.RemoveAt(i);
                    i--;
                }
            }

            collection.Reverse();

            if (collection.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(string.Join(" ", collection));
            }
        }
    }
}
