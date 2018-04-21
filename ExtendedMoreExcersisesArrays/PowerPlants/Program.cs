using System;
using System.Linq;

namespace PowerPlants
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] plantsPower = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int days = plantsPower.Length;
            int survivedDays = 0;
            int survivedSeasons = 0;

            while (plantsPower.Sum() > 0)
            {
                for (int i = 0; i < days; i++)
                {
                    survivedDays++;

                    for (int j = 0; j < plantsPower.Length; j++)
                    {
                        if (plantsPower[j] > 0)
                        {
                            plantsPower[j]--;

                            if (i == j)
                            {
                                plantsPower[j]++;
                            }
                        }
                    }

                    if (plantsPower.Sum() <= 0)
                    {
                        break;
                    }
                }

                survivedSeasons++;

                for (int i = 0; i < plantsPower.Length; i++)
                {
                    if (plantsPower[i] > 0)
                    {
                        plantsPower[i]++;
                    }
                }
            }

            if (survivedSeasons - 1 == 1)
            {
                Console.WriteLine("survived {0} days ({1} season)", survivedDays, survivedSeasons - 1);
            }
            else
            {
                Console.WriteLine("survived {0} days ({1} seasons)", survivedDays, survivedSeasons - 1);
            }
        }
    }
}
