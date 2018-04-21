using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace Weather
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, Dictionary<double, string>> weather = new Dictionary<string, Dictionary<double, string>>();
            string pattern = @"(?<city>[A-Z][A-Z])(?<temperature>[0-9]+(\.[0-9]{1,2})?)(?<condition>[a-zA-Z]+)\|";

            while (input != "end")
            {
                MatchCollection matches = Regex.Matches(input, pattern);

                foreach (Match match in matches)
                {
                    string city = match.Groups["city"].ToString();
                    double temperature = double.Parse(match.Groups["temperature"].ToString());
                    string condition = match.Groups["condition"].ToString();

                    if (!weather.ContainsKey(city))
                    {
                        Dictionary<double, string> current = new Dictionary<double, string>();
                        current.Add(temperature, condition);
                        weather.Add(city, current);
                    }
                    else
                    {
                        weather[city].Clear();
                        weather[city].Add(temperature, condition);

                    }
                }

                input = Console.ReadLine();
            }

            foreach (var kvp in weather.OrderBy(x => x.Value.Keys.Average()))
            {
                foreach (var kvp2 in kvp.Value)
                {
                    Console.WriteLine($"{kvp.Key} => {kvp2.Key:f2} => {kvp2.Value}");
                }
            }
        }
    }
}
