using System;
using System.Linq;

namespace Heists
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] priceGoods = Console.ReadLine().Split().Select(double.Parse).ToArray();
            double priceJewels = priceGoods[0];
            double priceGold = priceGoods[1];

            string input = Console.ReadLine();
            char gold = '$';
            char jewels = '%';
            double totalExpences = 0;
            double totalEarnings = 0;

            while (input != "Jail Time")
            {
                string[] heist = input.Split().ToArray();
                string loot = heist[0];
                double expences = double.Parse(heist[1]);

                foreach (char letters in loot)
                {
                    if (letters == gold)
                    {
                        totalEarnings += priceGold;
                    }
                    else if (letters == jewels)
                    {
                        totalEarnings += priceJewels;
                    }
                }

                totalExpences += expences;

                input = Console.ReadLine();
            }

            if (totalEarnings >= totalExpences)
            {
                Console.WriteLine("Heists will continue. Total earnings: {0}.", totalEarnings - totalExpences);
            }
            else
            {
                Console.WriteLine("Have to find another job. Lost: {0}.", totalExpences - totalEarnings);
            }
        }
    }
}
