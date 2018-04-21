using System;

namespace RestaurantDiscount
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupSize = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();

            double price = 0.0;
            string hall = "";

            if (groupSize <= 50)
            {
                hall = "Small Hall";
                price = 2500;
            }
            else if (groupSize <= 100)
            {
                hall = "Terrace";
                price = 5000;
            }
            else if (groupSize <= 120)
            {
                hall = "Great Hall";
                price = 7500;
            }

            if (package == "Normal")
            {
                price += 500;
                price *= 0.95;
            }
            else if (package == "Gold")
            {
                price += 750;
                price *= 0.9;
            }
            else if (package == "Platinum")
            {
                price += 1000;
                price *= 0.85;
            }

            if (groupSize > 120)
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
            else
            {
                Console.WriteLine($"We can offer you the {hall}\r\nThe price per person is {price/groupSize:f2}$");
            }
        }
    }
}
