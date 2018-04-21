using System;
using System.Linq;

namespace LargestCommonEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] collection1 = Console.ReadLine().Split();
            string[] collection2 = Console.ReadLine().Split();

            long longestLength = 0;
            long leftLength = 0;

            for (long i = 0; i < Math.Min(collection1.Length, collection2.Length); i++)
            {
                if (collection1[i] == collection2[i])
                {
                    leftLength++;
                }
                else
                {
                    break;
                }

                if (leftLength > longestLength)
                {
                    longestLength = leftLength;
                }
            }

            long rightLength = 0;
            long j = 0;

            for (long i = Math.Max(collection1.Length, collection2.Length) ; i > Math.Max(collection1.Length, collection2.Length) - Math.Min(collection1.Length, collection2.Length); i--)
            {

                if (collection1[collection1.Length - 1 - j] == collection2[collection2.Length - 1 - j])
                {
                    rightLength++;
                }
                else
                {
                    break;
                }

                if (rightLength > longestLength)
                {
                    longestLength = rightLength;
                }

                j++;
            }

            Console.WriteLine(longestLength);
        }
    }
}
