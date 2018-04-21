using System;
using System.Linq;

namespace RoundingNumbersAwayFromZero
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] collection = Console.ReadLine().Split().Select(double.Parse).ToArray();
            int[] roundedCollection = new int[collection.Length];

            for (int i = 0; i < collection.Length; i++)
            {
                roundedCollection[i] = (int)Math.Round(collection[i], MidpointRounding.AwayFromZero);
            }

            for (int i = 0; i < roundedCollection.Length; i++)
            {
                Console.WriteLine($"{collection[i]} => {roundedCollection[i]}");
            }
        }
    }
}
