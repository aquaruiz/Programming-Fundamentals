using System;
using System.Linq;

namespace ExtractMiddle123Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] collection = Console.ReadLine().Split().Select(int.Parse).ToArray();

            if (collection.Length == 1)
            {
                Console.WriteLine($"{{ {collection[0]} }}");
            }
            else if (collection.Length % 2 == 0)
            {
                Console.WriteLine("{{ {0}, {1} }}", collection[collection.Length / 2 - 1], collection[collection.Length / 2]);
            }
            else if (collection.Length % 2 == 1)
            {
                Console.WriteLine("{{ {0}, {1}, {2} }}", collection[collection.Length / 2 - 1], collection[collection.Length / 2], collection[collection.Length / 2 + 1]);
            }
        }
    }
}
