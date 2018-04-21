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
            double[] prices = Console.ReadLine().Split().Select(double.Parse).ToArray();

            string command = Console.ReadLine();

            while (command != "done")
            {
                string[] currentsProductNeeds = command.Split();
                string currentProductName = currentsProductNeeds[0];
                long currentProductQnty = long.Parse(currentsProductNeeds[1]);
                long avaiableQnty = 0;

                for (int i = 0; i < productsName.Length; i++)
                {
                    if (productsName[i] == currentProductName)
                    {
                        try
                        {
                            avaiableQnty = qnties[i];
                        }
                        catch { }

                        if (avaiableQnty >= currentProductQnty)
                        {
                            qnties[i] -= currentProductQnty; 
                            Console.WriteLine($"{currentProductName} x {currentProductQnty} costs {(currentProductQnty * prices[i]):f2}");
                        }
                        else
                        {
                            Console.WriteLine("We do not have enough {0}", currentProductName);
                        }
                        //Console.WriteLine("{0} costs: {1}; Available quantity: {2}", currentProductName, prices[i], qnties[i]);
                    }
                }

                command = Console.ReadLine();
            }
        }
    }
}
