using System;
using System.Linq;

namespace SumArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] collection1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] collection2 = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] sumCollection = new int[collection1.Length > collection2.Length ? collection1.Length : collection2.Length];

            for (int i = 0; i < (collection1.Length > collection2.Length ? collection1.Length : collection2.Length); i++)
            {
                sumCollection[i % sumCollection.Length] = collection1[i % collection1.Length] + collection2[i % collection2.Length];
            }

            Console.WriteLine(string.Join(" ", sumCollection));
        }
    }
}
