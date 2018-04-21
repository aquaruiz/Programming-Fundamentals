using System;

namespace ConvertSpeedUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            var distanceInMeters = int.Parse(Console.ReadLine());
            var hours = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());
            var seconds = int.Parse(Console.ReadLine());

            var timeInSeconds = seconds + 60.0 * minutes + 60.0 * 60.0 * hours;
            var speedMeterPerSecond = distanceInMeters / timeInSeconds;
            var speedKilometersInHours = (distanceInMeters / 1000.0) / (timeInSeconds / 60.0 / 60.0);
            var speedMilesPerHour = (distanceInMeters / 1609.0) / (timeInSeconds / 60.0 / 60.0);

            Console.WriteLine($"{speedMeterPerSecond:0.######}\n{speedKilometersInHours:0.######}\n{speedMilesPerHour:0.######}");
        }
    }
}
