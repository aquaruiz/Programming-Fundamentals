using System;

namespace BeverageLabels
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            var volume = int.Parse(Console.ReadLine());
            var energyContentPer100ml = int.Parse(Console.ReadLine());
            var sugarContentPer100ml = int.Parse(Console.ReadLine());

            var energyContentForGivenVolume = volume * energyContentPer100ml / 100.0;
            var sugarContentForGivenVolume = volume * sugarContentPer100ml / 100.0;

            Console.WriteLine($"{volume}ml {name}:");
            Console.WriteLine($"{energyContentForGivenVolume}kcal, {sugarContentForGivenVolume}g sugars");
        }
    }
}
