using System;

namespace CharacterStats
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            var currentHealth = int.Parse(Console.ReadLine());
            var maximumHealth = int.Parse(Console.ReadLine());
            var currentEnergy = int.Parse(Console.ReadLine());
            var maximumEnergy = int.Parse(Console.ReadLine());

            var health = new string('|', currentHealth) + new string('.', maximumHealth - currentHealth);
            var energy = new string('|', currentEnergy) + new string('.', maximumEnergy - currentEnergy);

            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Health: |" + health + "|");
            Console.WriteLine("Energy: |" + energy + "|");
        }
    }
}
