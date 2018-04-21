using System;

namespace BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            double maxVolume = double.MinValue;
            string winnerKegModel = "";

            for (int i = 0; i < number; i++)
            {
                string kegModel = Console.ReadLine();
                double kegRadius = double.Parse(Console.ReadLine());
                long kegHeigth = long.Parse(Console.ReadLine());

                var kegVolume = Math.PI * Math.Pow(kegRadius, 2) * kegHeigth;
                if (kegVolume > maxVolume)
                {
                    maxVolume = kegVolume;
                    winnerKegModel = kegModel;
                }
            }

            Console.WriteLine(winnerKegModel);
        }
    }
}
