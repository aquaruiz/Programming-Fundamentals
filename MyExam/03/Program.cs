using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
           // string pattern1 = @"(?<planetName>(?<=@)[a-zA-Z]+)[^@>-]*(?<planetPopulation>(?<=:)[0-9]+)[^@>-]*(?<attackType>(?<=!)[A|D](?=!))[^@]*(?<soldierCount>(?<=->)[0-9]+)";
            string pattern = @"(?<planetName>@[a-zA-Z]+)[^@!:>-]*(?<planetPopulation>:[0-9]+)[^@!:>-]*(?<attackType>![A|D]!)[^@!:>-]*(?<soldierCount>->[0-9]+)";

            Dictionary<string, int> attackedPlanets = new Dictionary<string, int>();
            Dictionary<string, int> destroyedPlanets = new Dictionary<string, int>();

            for (int i = 0; i < n; i++)
            {
                string message = Console.ReadLine();
                long starsQnty = CountStars(message);
                message = EncryptMessage(message, starsQnty);

                Match match = Regex.Match(message, pattern);

                if (match.Success)
                {
                    if (match.Groups["attackType"].ToString().Trim('!') == "A")
                    {
                        if (!attackedPlanets.ContainsKey(match.Groups["planetName"].ToString().TrimStart('@')))
                        {
                            attackedPlanets.Add(match.Groups["planetName"].ToString().Trim('@'), 1);
                        }
                        else
                        {
                            attackedPlanets[match.Groups["planetName"].ToString().TrimStart('@')]++;
                        }
                    }
                    else if (match.Groups["attackType"].ToString().Trim('!') == "D")
                    {
                        if (!destroyedPlanets.ContainsKey(match.Groups["planetName"].ToString().TrimStart('@')))
                        {
                            destroyedPlanets.Add(match.Groups["planetName"].ToString().TrimStart('@'), 1);
                        }
                        else
                        {
                            destroyedPlanets[match.Groups["planetName"].ToString().TrimStart('@')]++;
                        }
                    }
                }
            }

            attackedPlanets = attackedPlanets.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
            destroyedPlanets = destroyedPlanets.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

            Console.WriteLine($"Attacked planets: {attackedPlanets.Count()}");

            if (attackedPlanets.Count > 0)
            {
                foreach (var planet in attackedPlanets)
                {
                    Console.WriteLine($"-> {planet.Key}");
                }
            }

            Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count()}");
            if (destroyedPlanets.Count > 0)
            {
                foreach (var planet in destroyedPlanets)
                {
                    Console.WriteLine($"-> {planet.Key}");
                }
            }
        }

        private static string EncryptMessage(string message, long starsQnty)
        {
            string encryptedMessage = string.Empty;
            List<char> currentList = new List<char>();
            for (int i = 0; i < message.Length; i++)
            {
                currentList.Add((char)(message[i] - starsQnty));
            }

            encryptedMessage = string.Join("", currentList);
            return encryptedMessage;
        }

        private static long CountStars(string message)
        {
            long counter = 0;

            for (int i = 0; i < message.Length; i++)
            {
                if (message[i] == 's'
                    || message[i] == 't'
                    || message[i] == 'a'
                    || message[i] == 'r'
                    || message[i] == 'S'
                    || message[i] == 'T'
                    || message[i] == 'A'
                    || message[i] == 'R')
                {
                    counter++;
                }
            }

            return counter;
        }
    }
}
