using System;
using System.Linq;

namespace InventoryMatcher
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] productsName = Console.ReadLine().Split().ToArray();
            long[] qnties = Console.ReadLine().Split().Select(long.Parse).ToArray();
            string[] prices = Console.ReadLine().Split().ToArray();

            string command = Console.ReadLine();

            while (command != "done")
            {
                string currentsProduct = command;

                for (int i = 0; i < productsName.Length; i++)
                {
                    if (productsName[i] == currentsProduct)
                    {
                        Console.WriteLine("{0} costs: {1}; Available quantity: {2}", currentsProduct, prices[i], qnties[i]);
                    }
                }

                command = Console.ReadLine();
            }
        }
    }
}
