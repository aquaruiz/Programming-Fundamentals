using System;
using System.Collections.Generic;
using System.Linq;

namespace EqualSumAfterExtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondList = Console.ReadLine().Split().Select(int.Parse).ToList();

            int length = firstList.Count < secondList.Count ? firstList.Count : secondList.Count;

            for (int i = 0; i < firstList.Count; i++)
            {
                if (secondList.Contains(firstList[i]))
                {
                    secondList.RemoveAll(s => s == firstList[i]);
                }
            }

            int sumFirstList = firstList.Sum();
            int sumSecondList = secondList.Sum();

            if (sumFirstList == sumSecondList)
            {
                Console.WriteLine("Yes. Sum: {0}", sumSecondList);
            }
            else
            {
                Console.WriteLine("No. Diff: {0}", Math.Abs(sumSecondList - sumFirstList));
            }
        }
    }
}
