using System;

namespace NeighbourWars
{
    class Program
    {
        static void Main(string[] args)
        {
            int peshoDamage = int.Parse(Console.ReadLine());
            int goshoDamage = int.Parse(Console.ReadLine());

            int peshoHealth = 100;
            int goshoHealth = 100;

            string attacker = "";
            string attackName = "";
            string defender = "";
            int defenderHealth = 0;
            int counter = 0;

            while (true)
            {
                counter++;
                if (counter % 2 == 0)
                {
                    attacker = "Gosho";
                    attackName = "Thunderous fist";
                    defender = "Pesho";
                    peshoHealth -= goshoDamage;
                    defenderHealth = peshoHealth;
                    if (peshoHealth > 0)
                    {
                        Console.WriteLine($"{attacker} used {attackName} and reduced {defender} to {defenderHealth} health.");
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    attacker = "Pesho";
                    attackName = "Roundhouse kick";
                    defender = "Gosho";
                    goshoHealth -= peshoDamage;
                    defenderHealth = goshoHealth;
                    if (goshoHealth > 0)
                    {
                        Console.WriteLine($"{attacker} used {attackName} and reduced {defender} to {defenderHealth} health.");
                    }
                    else
                    {
                        break;
                    }
                }

                if (counter % 3 == 0)
                {
                    peshoHealth += 10;
                    goshoHealth += 10;
                }
            }
            Console.WriteLine($"{attacker} won in {counter}th round.");
        }
    }
}