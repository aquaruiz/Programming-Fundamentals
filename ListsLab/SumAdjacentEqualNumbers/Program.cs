using System;
using System.Collections.Generic;
using System.Linq;

namespace SumAdjacentEqualNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> collection = Console.ReadLine().Split().Select(double.Parse).ToList();

            for (int i = 0; i < collection.Count - 1; i++)
            {
                if (collection[i] == collection[i + 1])
                {
                    collection.Insert(i, collection[i] + collection[i + 1]);
                    collection.RemoveAt(i + 1);
                    collection.RemoveAt(i + 1);

                    if (i == 0)
                    {
                        i--;
                    }
                    else
                    {
                        i--;
                        i--;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", collection));
        }
    }
}
