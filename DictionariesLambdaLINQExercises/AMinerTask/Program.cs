using System;
using System.Collections.Generic;

namespace AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, int> mining = new Dictionary<string, int>();

            while (input != "stop")
            {
                string metal = input;
                int qnty = int.Parse(Console.ReadLine());

                if (!mining.ContainsKey(metal))
                {
                    mining.Add(metal, qnty);
                }
                else
                {
                    mining[metal] += qnty;
                }

                input = Console.ReadLine();
            }

            foreach (var metalQnty in mining)
            {
                Console.WriteLine($"{metalQnty.Key} -> {metalQnty.Value}");
            }
        }
    }
}
