using System;
using System.Collections.Generic;
using System.Linq;

namespace SumMinMaxAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<int> input = new List<int>();

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                input.Add(num);
            }

            Console.WriteLine("Sum = " + input.Sum());
            Console.WriteLine("Min = " + input.Min());
            Console.WriteLine("Max = " + input.Max());
            Console.WriteLine("Average = " + input.Average());
            //Console.WriteLine(input.First());
            //Console.WriteLine(input.Last());
        } 
    }
}
