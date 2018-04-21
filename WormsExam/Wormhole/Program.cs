using System;
using System.Linq;

namespace Wormhole
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] wormholesWannabes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int counter = 0;
            int index = 0;

            while (index < wormholesWannabes.Length)
            {
                int current = wormholesWannabes[index];

                if (current == 0)
                {
                    index++;
                    counter++;
                }
                else
                {
                    wormholesWannabes[index] = 0;
                    index = current;
                }
            }

            Console.WriteLine(counter);
        }
    }
}
