using System;

namespace CakeIngredients
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            int counter = 0;

            while (input != "Bake!")
            {
                Console.WriteLine($"Adding ingredient {input}.");
                counter++;
                input = Console.ReadLine();
            }
            Console.WriteLine($"Preparing cake with {counter} ingredients.");
        }
    }
}
