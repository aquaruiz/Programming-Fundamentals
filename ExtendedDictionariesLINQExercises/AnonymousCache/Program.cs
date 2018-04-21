using System;
using System.Collections.Generic;
using System.Linq;

namespace AnonymousCache
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, Dictionary<string, int>> dataSets = new Dictionary<string, Dictionary<string, int>>();
            Dictionary<string, Dictionary<string, int>> cache = new Dictionary<string, Dictionary<string, int>>();

            while (input != "thetinggoesskrra")
            {
                string dataSet = string.Empty;
                string dataKey = string.Empty;
                int dataSize = 0;

                if (!input.Contains(" -> "))
                {
                    dataSet = input;
                    dataSets.Add(dataSet, new Dictionary<string, int>());
                    
                    if (cache.ContainsKey(dataSet))
                    {
                        foreach (var kvp in cache[dataSet])
                        {
                            dataSets[dataSet].Add(kvp.Key, kvp.Value);
                        }
                    }
                }
                else
                {
                    string[] current = input.Split("-> |".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToArray();
                    dataSet = current[2];
                    dataKey = current[0];
                    dataSize = int.Parse(current[1]);

                    if (dataSets.ContainsKey(dataSet))
                    {
                        dataSets[dataSet].Add(dataKey, dataSize);
                    }
                    else
                    {
                        if (cache.ContainsKey(dataSet))
                        {
                            cache[dataSet].Add(dataKey, dataSize);
                        }
                        else
                        {
                            cache.Add(dataSet, new Dictionary<string, int>());
                            cache[dataSet].Add(dataKey, dataSize);
                        }
                    }
                }

                input = Console.ReadLine();
            }

            if (dataSets.Count != 0)
            {
                dataSets = dataSets.OrderByDescending(x => x.Value.Values.Sum()).ToDictionary(x => x.Key, x => x.Value);
                string outputDataSet = dataSets.First().Key;
                int totalSizeSum = dataSets.First().Value.Values.Sum();

                Console.WriteLine($"Data Set: {outputDataSet}, Total Size: {totalSizeSum}");

                foreach (var kvp in dataSets.First().Value)
                {
                    Console.WriteLine($"$.{kvp.Key}");
                }
            }
        }
    }
}
