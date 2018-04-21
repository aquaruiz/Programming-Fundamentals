using System;
using System.Linq;

namespace MostFrequentNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] collection = Console.ReadLine().Split().Select(int.Parse).ToArray();

            long counter = 0;
            long bestCounter = 0;
            int number = 0;
            int bestNumber = 0;

            for (int i = 0; i < collection.Length; i++)
            {
                for (int j = 0; j < collection.Length; j++)
                {
                    if (collection[i] == collection[j])
                    {
                        counter++;
                        number = collection[i];
                    }
                }

                if (counter > bestCounter)
                {
                    bestCounter = counter;
                    bestNumber = number;
                }

                counter = 0;
                number = 0;                
            }

            //if (collection.Length == 1)
            //{
            //    bestCounter = 1;
            //    bestNumber = collection[0];
            //}
            
            Console.WriteLine(bestNumber);
        }
    }
}
