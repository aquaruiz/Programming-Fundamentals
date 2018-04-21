using System;
using System.Collections.Generic;
using System.Linq;

namespace SumReversedNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> reversed = new List<int>();

            foreach (int number in input)
            {
                string strNum = number.ToString();
                char[] charNum = strNum.ToCharArray();
                Array.Reverse(charNum);
                strNum = string.Join("", charNum).ToString();
                int reversedNum = int.Parse(strNum);

                reversed.Add(reversedNum);
            }

            Console.WriteLine(reversed.Sum());
        }
    }
}
