using System;
using System.Collections.Generic;
using System.Linq;

namespace ArrayHistogram
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            Dictionary<string, int> wordOccurances = new Dictionary<string, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (!wordOccurances.ContainsKey(input[i]))
                {
                    wordOccurances[input[i]] = 1;                    
                }
                else
                {
                    wordOccurances[input[i]]++;                    
                }
            }

            double sumOccurances = wordOccurances.Sum(x => x.Value);

            wordOccurances = wordOccurances.OrderByDescending(s => s.Value).ToDictionary(x => x.Key, x => x.Value);

            foreach (var pair in wordOccurances)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value} times ({((pair.Value / sumOccurances) * 100):f2}%)");
            }
        }
    }
}
