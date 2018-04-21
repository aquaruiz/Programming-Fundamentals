using System;
using System.Linq;

namespace EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] collection = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int leftSum = 0;
            int rightSum = 0;
            bool found = false;
            int index = 0;

            for (int i = 0; i < collection.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    leftSum += collection[j];
                }

                for (int k = i + 1; k < collection.Length; k++)
                {
                    rightSum += collection[k];
                }

                if (leftSum == rightSum)
                {
                    found = true;
                    index = i;
                }

                leftSum = 0;
                rightSum = 0;
            }

            if (found)
            {
                Console.WriteLine(index);
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
