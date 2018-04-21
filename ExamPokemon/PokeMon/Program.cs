using System;

namespace PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            long pokePower = long.Parse(Console.ReadLine());
            long distanceBetweenTargets = long.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());
            long targetsPoked = 0;
            long originalPokePower = pokePower;

            while (pokePower >= distanceBetweenTargets)
            {
                pokePower -= distanceBetweenTargets;
                targetsPoked++;

                if (pokePower == 0.5 * originalPokePower && pokePower > exhaustionFactor && pokePower != 0 && exhaustionFactor != 0) //?
                {
                    pokePower /= exhaustionFactor; 
                }
            }

            Console.WriteLine(pokePower);
            Console.WriteLine(targetsPoked);
        }
    }
}
