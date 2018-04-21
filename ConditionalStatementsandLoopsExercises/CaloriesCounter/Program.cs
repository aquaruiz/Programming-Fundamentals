using System;

namespace CaloriesCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            var cheeseCalories = 500;
            var tomatoSauceCalories = 150;
            var salamiCalories = 600;
            var pepperCalories = 50;

            var number = int.Parse(Console.ReadLine());
           
            var sumCalories = 0;

            for (int i = 0; i < number; i++)
            {
                var input = Console.ReadLine().ToLower();
                if (input == "cheese")
                {
                    sumCalories += cheeseCalories;
                }
                else if (input == "tomato sauce")
                {
                    sumCalories += tomatoSauceCalories;
                }
                else if (input == "salami")
                {
                    sumCalories += salamiCalories;
                }
                else if (input == "pepper")
                {
                    sumCalories += pepperCalories; 
                }
            }

            Console.WriteLine("Total calories: {0}", sumCalories);
        }
    }
}
