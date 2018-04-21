using System;

namespace PriceChangeAlert
{
    class Program
    {
        static void Main(string[] args)
        {
            int pricesQnty = int.Parse(Console.ReadLine());
            double significanceTreshold = double.Parse(Console.ReadLine());
            double firstPrice = double.Parse(Console.ReadLine());

            for (int i = 0; i < pricesQnty - 1; i++)
            {
                double currentPrice = double.Parse(Console.ReadLine());
                double priceDifference = GetPriceDifference(firstPrice, currentPrice);
                bool isSignificantDifference = IsDiffSignificant(priceDifference, significanceTreshold);
                string message = GetMessage(currentPrice, firstPrice, priceDifference, isSignificantDifference);
                Console.WriteLine(message);
                firstPrice = currentPrice;
            }
        }

        static string GetMessage(double currentPrice, double firstPrice, double priceDifference, bool isSignificantDifference)
        {
            string message = "";

            if (priceDifference == 0)
            {
                message = string.Format("NO CHANGE: {0}", currentPrice);
            }
            else if (!isSignificantDifference)
            {
                message = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", firstPrice, currentPrice, 100 * priceDifference);
            }
            else if (isSignificantDifference && (priceDifference > 0))
            {
                message = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", firstPrice, currentPrice, 100 * priceDifference);
            }
            else if (isSignificantDifference && (priceDifference < 0))
            {
                message = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", firstPrice, currentPrice, 100 * priceDifference);
            }

            return message;
        }

        static bool IsDiffSignificant(double priceDifference, double significanceTreshold)
        {
            if (Math.Abs(priceDifference) >= significanceTreshold)
            {
                return true;
            }

            return false;
        }

        static double GetPriceDifference(double firstPrice, double currentPrice)
        {
            double difference = (currentPrice - firstPrice) / firstPrice;
            return difference;
        }
    }
}