using System;

namespace TouristInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            var imperialUnit = Console.ReadLine();
            var imperialUnitValue = double.Parse(Console.ReadLine());

            var merticUnit = "";
            var metricUnitValue = 0.0;

            switch (imperialUnit)
            {
                case "miles":
                    metricUnitValue = imperialUnitValue * 1.6;
                    merticUnit = "kilometers";
                    break;
                case "inches":
                    metricUnitValue = imperialUnitValue * 2.54;
                    merticUnit = "centimeters";
                    break;
                case "feet":
                    metricUnitValue = imperialUnitValue * 30;
                    merticUnit = "centimeters";
                    break;
                case "yards":
                    metricUnitValue = imperialUnitValue * 0.91;
                    merticUnit = "meters";
                    break;
                case "gallons":
                    metricUnitValue = imperialUnitValue * 3.8;
                    merticUnit = "liters";
                    break;
            }

            Console.WriteLine($"{imperialUnitValue} {imperialUnit} = {metricUnitValue:f2} {merticUnit}");
        }
    }
}
