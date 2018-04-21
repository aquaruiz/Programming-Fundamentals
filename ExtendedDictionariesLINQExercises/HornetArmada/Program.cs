using System;
using System.Collections.Generic;
using System.Linq;

namespace HornetArmada
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, int> legionActivity = new Dictionary<string, int>();
            Dictionary<string, Dictionary<string, int>> legionSoldierTypeCount = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split("-> :=".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToArray();
                int lastActivity = int.Parse(input[0]);
                string legionName = input[1];
                string soldierType = input[2];
                int soldierCount = int.Parse(input[3]);

                if (!legionSoldierTypeCount.ContainsKey(legionName))
                {
                    legionSoldierTypeCount.Add(legionName, new Dictionary<string, int>());
                    legionActivity.Add(legionName, 0);
                }

                if (!legionSoldierTypeCount[legionName].ContainsKey(soldierType))
                {
                    legionSoldierTypeCount[legionName].Add(soldierType, 0);
                }

                legionSoldierTypeCount[legionName][soldierType] += soldierCount;

                if (legionActivity[legionName] < lastActivity)
                {
                    legionActivity[legionName] = lastActivity;
                }
            }

            string line = Console.ReadLine();

            if (line.Contains('\\'))
            {
                string[] command = line.Split('\\', StringSplitOptions.RemoveEmptyEntries).ToArray();
                int activi = int.Parse(command[0]);
                string soldierType = command[1];
                Dictionary<string, int> current = new Dictionary<string, int>();

                foreach (var activity in legionActivity.Where(x => x.Value < activi))
                {
                    foreach (var kvp in legionSoldierTypeCount[activity.Key].Where(x => x.Key.Equals(soldierType)).OrderByDescending(x => x.Value))
                    {
                        current.Add(activity.Key, kvp.Value);
                    }
                }

                foreach (var cur in current.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"{cur.Key} -> {cur.Value}");
                }
            }
            else
            {
                string soldierType = line;
                Dictionary<string, int> current = new Dictionary<string, int>();
                
                foreach (var kvp in legionSoldierTypeCount)
                {
                    foreach (var soldier in kvp.Value)
                    {
                        if (soldier.Key.Equals(soldierType))
                        {
                            current.Add(kvp.Key, legionActivity[kvp.Key]);
                        }
                    }
                    //    foreach (var activity in legionActivity.Where(x => x.Value.Equals(kvp.Value.Keys)).OrderByDescending(x => x.Value))
                    //    {
                    //        Console.WriteLine($"{activity.Key} : {activity.Value}");
                    //    }
                }

                foreach (var legion in current.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"{legion.Value} : {legion.Key}");
                }
            }
        }
    }
}
