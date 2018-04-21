using System;
using System.Collections.Generic;
using System.Linq;

namespace RabbitHole
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> obstaclesToOvercome = Console.ReadLine().Split().ToList();
            int initialEnergy = int.Parse(Console.ReadLine());

            while (initialEnergy > 0)
            {
                int i = 0;
                string obstacle = obstaclesToOvercome[i];
                string stepDirection = obstacle.Split('|')[0];

                if (stepDirection == "RabbitHole")
                {
                    Console.WriteLine("You have 5 years to save Kennedy!");
                    return;
                }
                else
                {
                    int stepSize = int.Parse(obstacle.Split('|')[1]);
                    if (stepDirection == "Right")
                    {
                        i = (i + stepSize) % obstaclesToOvercome.Count;
                        initialEnergy -= stepSize;
                    }
                    else if (stepDirection == "Left")
                    {
                        i = Math.Abs((stepSize - i) % obstaclesToOvercome.Count);
                        initialEnergy -= stepSize;
                    }
                    else if (stepDirection == "Bomb")
                    {
                        obstaclesToOvercome.RemoveAt(i);
                        i = 0;
                        initialEnergy -= stepSize;

                        if (initialEnergy <= 0)
                        {
                            Console.WriteLine("You are dead due to bomb explosion!");
                            return;
                        }
                    }
                }

                if (obstaclesToOvercome[obstaclesToOvercome.Count - 1] == "RabbitHole")
                {
                    obstaclesToOvercome.Add($"Bomb|{initialEnergy}");
                }
                else
                {
                    obstaclesToOvercome.RemoveAt(obstaclesToOvercome.Count - 1);
                    obstaclesToOvercome.Add($"Bomb|{initialEnergy}");
                }
            }

            Console.WriteLine("You are tired. You can't continue the mission.");
        }
    }
}
