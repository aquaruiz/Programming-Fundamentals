using System;

namespace WeatherForecast
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string weather = "";

            try
            {
                sbyte number = sbyte.Parse(input);
                weather = "Sunny";
            }
            catch
            {
                try
                {
                    int number = int.Parse(input);
                    weather = "Cloudy";
                }
                catch
                {
                    try
                    {
                        long number = long.Parse(input);
                        weather = "Windy";
                    }
                    catch
                    {
                        double number = double.Parse(input);
                        weather = "Rainy";
                    }
                }                
            }

            Console.WriteLine(weather);
        }
    }
}
