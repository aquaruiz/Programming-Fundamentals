using System;

namespace ChooseADrink2
{
    class Program
    {
        static void Main(string[] args)
        {
            var profession = Console.ReadLine();
            var qnty = int.Parse(Console.ReadLine());

            double price = 0.0;

            if (profession == "Athlete")
            {
                price = 0.70;
            }
            else if (profession == "Businessman" || profession == "Businesswoman")
            {
                price = 1.00;
            }
            else if (profession == "SoftUni Student")
            {
                price = 1.70;
            }
            else
            {
                price = 1.20;
            }

            Console.WriteLine($"The {profession} has to pay {(qnty * price):f2}.");
        }
    }
}
