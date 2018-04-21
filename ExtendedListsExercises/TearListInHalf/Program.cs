using System;
using System.Collections.Generic;
using System.Linq;

namespace TearListInHalf
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> topList = new List<int>();
            List<int> bottomList = new List<int>();
            List<int> output = new List<int>();

            for (int i = 0; i < input.Count / 2; i++)
            {
                bottomList.Add(input[i]);
            }
                        
            for (int i = input.Count/ 2; i < input.Count; i++)
            {
                topList.Add(input[i]);                
            }

            for (int i = 0; i < topList.Count; i++)
            {
                int leftDigit = int.Parse(topList[i].ToString()[0].ToString());
                int rightDigit = int.Parse(topList[i].ToString()[1].ToString());

                output.Add(leftDigit);
                output.Add(bottomList[i]);
                output.Add(rightDigit);
            }

            Console.WriteLine(string.Join(" ", output));
        }
    }
}
