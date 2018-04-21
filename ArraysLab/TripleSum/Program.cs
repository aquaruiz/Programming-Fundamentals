using System;
using System.Linq;

namespace TripleSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] collection = Console.ReadLine().Split().Select(int.Parse).ToArray();

            bool foundSum = false;
            for (int i = 0; i < collection.Length; i++)
            {
                for (int j = i; j < collection.Length; j++)
                {
                    int sum = 0;

                    if (i != j)
                    {
                        sum = collection[i] + collection[j];

                        if (collection.Contains(sum))
                        {
                            foundSum = true;
                            Console.WriteLine($"{collection[i]} + {collection[j]} == {sum}");
                        }
                    }
                }
            }

            if (!foundSum)
            {
                Console.WriteLine("No");
            }
        }
    }
}
