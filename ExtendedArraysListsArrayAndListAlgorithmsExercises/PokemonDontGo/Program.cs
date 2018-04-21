using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonDontGo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> pokemons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int shootIndex;
            int sum = 0;

            while (pokemons.Count > 0)
            {
                shootIndex = int.Parse(Console.ReadLine());

                if (shootIndex < 0)
                {
                    shootIndex = 0;
                    pokemons.Insert(1, pokemons[pokemons.Count - 1]);
                }

                if (shootIndex > pokemons.Count - 1)
                {
                    pokemons.Insert(pokemons.Count - 1, pokemons[0]);
                    shootIndex = pokemons.Count - 1;
                }

                int capturedValue = pokemons[shootIndex];
                sum += capturedValue;
                pokemons.RemoveAt(shootIndex);

                for (int i = 0; i < pokemons.Count; i++)
                {
                    if (pokemons[i] <= capturedValue)
                    {
                        pokemons[i] += capturedValue;
                    }
                    else if (pokemons[i] > capturedValue)
                    {
                        pokemons[i] -= capturedValue;
                    }
                }
            }

            Console.WriteLine(sum);
        }
    }
}
