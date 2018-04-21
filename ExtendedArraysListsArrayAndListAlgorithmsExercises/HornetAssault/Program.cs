using System;
using System.Collections.Generic;
using System.Linq;

namespace HornetAssault
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> beesInBeehives = Console.ReadLine().Split().Select(long.Parse).ToList();
            List<long> powerOfEachHornet = Console.ReadLine().Split().Select(long.Parse).ToList();
            int indexOfBeehivesToStartFrom = 0;

            while (indexOfBeehivesToStartFrom < beesInBeehives.Count && beesInBeehives.Sum() != 0 && powerOfEachHornet.Count > 0)
            {
                long totalHornetsPower = powerOfEachHornet.Sum();

                for (int i = indexOfBeehivesToStartFrom; i < beesInBeehives.Count; i++)
                {
                    if (beesInBeehives[i] < totalHornetsPower)
                    {
                        beesInBeehives[i] = 0;
                    }
                    else
                    {
                        beesInBeehives[i] -= totalHornetsPower;
                        powerOfEachHornet.RemoveAt(0);
                        indexOfBeehivesToStartFrom = i + 1;
                        break;
                    }
                }
            }

            if (beesInBeehives.Sum() > 0)
            {
                foreach (var hives in beesInBeehives.Where(x => x!= 0))
                {
                    Console.Write(hives + " ");
                }

                Console.WriteLine();
            }
            else if (powerOfEachHornet.Sum() > 0)
            {
                Console.WriteLine(string.Join(" ", powerOfEachHornet));
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
