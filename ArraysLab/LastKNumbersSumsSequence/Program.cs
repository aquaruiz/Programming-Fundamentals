using System;

namespace LastKNumbersSumsSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int countElements = int.Parse(Console.ReadLine());
            int stepBackwards = int.Parse(Console.ReadLine());
            long[] collection = new long[countElements];

            collection[0] = 1;

            for (int i = 1; i < countElements; i++)
            {
                if (i < stepBackwards)
                {
                    for (int j = 0; j <= i; j++)
                    {
                        collection[i] += collection[i - j];
                    }
                }
                else
                {
                    for (int j = 1; j <= stepBackwards; j++)
                    {
                        collection[i] += collection[i - j];
                    }
                }
            }

            Console.WriteLine(string.Join(" ", collection));
        }
    }
}
