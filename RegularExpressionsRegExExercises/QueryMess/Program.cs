using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace QueryMess
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"([^&?]+)=([^&?]+)";
            Dictionary<string, List<string>> collection = new Dictionary<string, List<string>>();

            while (input != "END")
            {
                MatchCollection matches = Regex.Matches(input, pattern);

                foreach (Match match in matches)
                {
                    string collectedKey = match.Groups[1].Value.ToString();
                    string collectedValue = match.Groups[2].Value.ToString();

                    //if (match.Value.Contains("+") 
                    //    || match.Value.Contains("%20"))
                    //{
                    collectedKey = Regex.Replace(collectedKey, @"\+|%20", " ");
                    collectedKey = Regex.Replace(collectedKey, @"\s+", " ");
                    collectedKey = collectedKey.Trim();
                    collectedValue = Regex.Replace(collectedValue, @"\+|%20", " ");
                    collectedValue = Regex.Replace(collectedValue, @"\s+", " ");
                    collectedValue = collectedValue.Trim();
                    //}

                    if (!collection.ContainsKey(collectedKey))
                    {
                        collection[collectedKey] = new List<string>();
                        collection[collectedKey].Add(collectedValue);
                    }
                    else
                    {
                        collection[collectedKey].Add(collectedValue);
                    }
                }

                foreach (var kvp in collection)
                {
                    Console.Write($"{kvp.Key}=[{string.Join(", ", kvp.Value)}]");
                }

                Console.WriteLine();
                collection.Clear();
                input = Console.ReadLine();
            }
        }
    }
}
