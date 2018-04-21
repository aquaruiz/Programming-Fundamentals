using System;

namespace TrainingHallEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal budget = decimal.Parse(Console.ReadLine());
            int numberItems = int.Parse(Console.ReadLine());
            decimal spentMoney = 0.0m;

            for (int i = 0; i < numberItems; i++)
            {
                string itemName = Console.ReadLine();
                decimal itemPrice = decimal.Parse(Console.ReadLine());
                int itemQnty = int.Parse(Console.ReadLine());

                if (itemQnty > 1)
                {
                    itemName += "s";
                }

                spentMoney += itemPrice * itemQnty;
                Console.WriteLine($"Adding {itemQnty} {itemName} to cart.");
            }

            Console.WriteLine($"Subtotal: ${spentMoney:0.00}");
            if (spentMoney > budget)
            {
                Console.WriteLine($"Not enough. We need ${(spentMoney - budget):0.00} more.");
            }
            else
            {
                Console.WriteLine($"Money left: ${(budget - spentMoney):0.00}");
            }
        }
    }
}
