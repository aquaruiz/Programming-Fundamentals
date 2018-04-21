using System;
using System.Linq;

namespace PizzaIngredients
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] possibleIngredients = Console.ReadLine().Split().ToArray();
            long stringsLength = int.Parse(Console.ReadLine());

            int counter = 0;
            string totalIngredients = string.Empty;


            for (int i = 0; i < possibleIngredients.Length; i++)
            {
                string newIngredient = possibleIngredients[i];

                if (newIngredient.Length == stringsLength)
                {
                    Console.WriteLine("Adding {0}.", newIngredient);
                    counter++;
                    totalIngredients += newIngredient + ", ";
                }

                if (i == possibleIngredients.Length - 1 || counter >= 10)
                {
                    break;
                }
            }

            if (totalIngredients != string.Empty)
            {
                totalIngredients = totalIngredients.Remove(totalIngredients.Length - 2);
            }

            Console.WriteLine("Made pizza with total of {0} ingredients.", counter);
            Console.WriteLine("The ingredients are: {0}.", totalIngredients);
        }
    }
}
