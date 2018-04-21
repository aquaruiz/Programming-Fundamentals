using System;
using System.Collections.Generic;
using System.Linq;

namespace WormsWorldParty
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, Dictionary<string, long>> wormTeamsScores = new Dictionary<string, Dictionary<string, long>>();
            List<string> wormsSoFar = new List<string>();

            while (input != "quit")
            {
                string[] results = input.Split("->".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                string worm = results[0].Trim();
                string team = results[1].Trim();
                long score = long.Parse(results[2].Trim());

                if (!wormsSoFar.Contains(worm))
                {
                    if (!wormTeamsScores.ContainsKey(team))
                    {
                        wormTeamsScores.Add(team, new Dictionary<string, long>());
                    }

                    wormTeamsScores[team].Add(worm, score); //!
                    wormsSoFar.Add(worm);
                }

                input = Console.ReadLine();
            }

            //wormTeamsScores = wormTeamsScores.OrderByDescending(x => x.Value.Values.Sum()).ThenByDescending(x => x.Value.Values.Average()).ToDictionary(x=>x.Key, x=>x.Value);

            long counter = 1;
            foreach (var team in wormTeamsScores.OrderByDescending(x => x.Value.Values.Sum()).ThenByDescending(x => x.Value.Values.Average()))
            {
                Console.WriteLine($"{counter}. Team: {team.Key} - {team.Value.Values.Sum()}");
                counter++;

                foreach (var worm in team.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"###{worm.Key} : {worm.Value}");
                }
            }
        }
    }
}
