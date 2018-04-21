using System;

namespace VaporStore
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal currentBalance = decimal.Parse(Console.ReadLine());
            decimal spent = 0.0m;

            string command = Console.ReadLine();

            while (command != "Game Time")
            {
                decimal gamePrice = 0.0m;
                string gameName = "";
                switch (command)
                {
                    case "OutFall 4":
                        gamePrice = 39.99m;
                        gameName = "OutFall 4";
                        break;
                    case "CS: OG":
                        gamePrice = 15.99m;
                        gameName = "CS: OG";
                        break;
                    case "Zplinter Zell":
                        gamePrice = 19.99m;
                        gameName = "Zplinter Zell";
                        break;
                    case "Honored 2":
                        gamePrice = 59.99m;
                        gameName = "Honored 2";
                        break;
                    case "RoverWatch":
                        gamePrice = 29.99m;
                        gameName = "RoverWatch";
                        break;
                    case "RoverWatch Origins Edition":
                        gamePrice = 39.99m;
                        gameName = "RoverWatch Origins Edition";
                        break;
                    default:
                        Console.WriteLine("Not Found");
                        break;
                }

                if (gamePrice <= currentBalance && gameName != "")
                {
                    currentBalance -= gamePrice;
                    spent += gamePrice;
                    Console.WriteLine("Bought {0}", gameName);
                }
                else if (gamePrice > currentBalance && gameName != "")
                {
                    Console.WriteLine("Too Expensive");
                }

                if (currentBalance <= 0)
                {
                    Console.WriteLine("Out of money!");
                    break;
                }

                command = Console.ReadLine();
            }

            if (currentBalance > 0)
            {
                Console.WriteLine($"Total spent: ${spent:f2}. Remaining: ${currentBalance:f2}");
            }
        }
    }
}
