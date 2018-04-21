using System;
using System.Collections.Generic;
using System.Linq;

namespace OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().ToLower().Split();
            Dictionary<string, int> count = new Dictionary<string, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (! count.ContainsKey(input[i]))
                {
                    count.Add(input[i], 1);
                }
                else
                {
                    count[input[i]]++;
                }
            }

            List<string> output = new List<string>();

            foreach (var kvp in count.Where(x => x.Value % 2 == 1))
            {
                output.Add(kvp.Key);
            }

            Console.WriteLine(string.Join(", ", output));
        }
    }
}
