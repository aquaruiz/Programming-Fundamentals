using System;
using System.Collections.Generic;
using System.Linq;

namespace PopulationCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, Dictionary<string, long>> populationByCityCountry = new Dictionary<string, Dictionary<string, long>>();

            while (input != "report")
            {
                string[] statistics = input.Split('|').ToArray();
                string city = statistics[0];
                string country = statistics[1];
                long population = long.Parse(statistics[2]);

                Dictionary<string, long> cityPopulation = new Dictionary<string, long>();

                if (!populationByCityCountry.ContainsKey(country))
                {
                    cityPopulation.Add(city, population);
                    populationByCityCountry.Add(country, cityPopulation);
                }
                else
                {
                    if (!populationByCityCountry[country].ContainsKey(city))
                    {
                        populationByCityCountry[country].Add(city, population);
                    }
                    else
                    {
                        populationByCityCountry[country][city] += population;
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var cityPopulation in populationByCityCountry.OrderByDescending(x => x.Value.Sum(y => y.Value)))
            {
                Console.WriteLine($"{cityPopulation.Key} (total population: {cityPopulation.Value.Values.Sum()})");
                foreach (var city in cityPopulation.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"=>{city.Key}: {city.Value}");
                }
            }
        }
    }
}
