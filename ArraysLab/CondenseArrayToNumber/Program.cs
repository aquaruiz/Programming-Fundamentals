using System;
using System.Linq;

namespace CondenseArrayToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] collection = Console.ReadLine().Split().Select(int.Parse).ToArray();
            bool lamp = false;

            if (collection.Length == 1)
            {
                lamp = true;
            }

            while (collection.Length > 1)
            {
                int[] condensedCollection = new int[collection.Length - 1];

                for (int i = 0; i < condensedCollection.Length; i++)
                {
                    condensedCollection[i] = collection[i] + collection[i + 1];
                }

                collection = condensedCollection;
            }

            if (lamp == true)
            {
                Console.WriteLine("{0} is already condensed to number", collection[0]);
            }
            else
            {
                Console.WriteLine(collection[0]);
            }
        }
    }
}
