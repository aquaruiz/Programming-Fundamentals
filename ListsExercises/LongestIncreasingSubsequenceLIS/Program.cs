using System;
using System.Collections.Generic;
using System.Linq;

namespace LongestIncreasingSubsequenceLIS
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();

            int[] lengthOfLISEndingAtPositionP = new int[input.Count];
            int[] indexOfPreviousElement = new int[input.Count];
            int maxLength = 0;
            int lastIndex = -1;
            int counter = 1;

            for (int i = 0; i < input.Count; i++)
            {
                lengthOfLISEndingAtPositionP[i] = 1;
                indexOfPreviousElement[i] = -1;

                for (int j = 0; j < i; j++)
                {
                    if (input[j] < input[i] && lengthOfLISEndingAtPositionP[j] >= lengthOfLISEndingAtPositionP[i])
                    {
                        counter++;
                        lengthOfLISEndingAtPositionP[i] = counter;
                        indexOfPreviousElement[i] = j;
                    }
                }
                counter = 1;

                if (lengthOfLISEndingAtPositionP[i] > maxLength)
                {
                    maxLength = lengthOfLISEndingAtPositionP[i];
                    lastIndex = i;
                }
            }

            List<int> longestSequence = new List<int>();

            for (int i = 0; i < maxLength; i++)
            {
                longestSequence.Add(input[lastIndex]);
                lastIndex = indexOfPreviousElement[lastIndex];
            }

            longestSequence.Reverse();

            Console.WriteLine("{0}", string.Join(" ", longestSequence));
        }
    }
}
