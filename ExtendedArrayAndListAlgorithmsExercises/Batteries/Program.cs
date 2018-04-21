using System;
using System.Linq;

namespace Batteries
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] batteryCapacities = Console.ReadLine().Split().Select(double.Parse).ToArray();
            double[] usagePerHour = Console.ReadLine().Split().Select(double.Parse).ToArray();
            double streeeTestHours = double.Parse(Console.ReadLine());
            int[] batteryLasts = new int[batteryCapacities.Length];

            for (int i = 0; i < streeeTestHours; i++)
            {
                for (int j = 0; j < batteryCapacities.Length; j++)
                {
                    if (batteryCapacities[j] > 0)
                    {
                        batteryCapacities[j] -= usagePerHour[j];
                        batteryLasts[j]++;
                    }                   
                }
            }

            for (int i = 0; i < batteryCapacities.Length; i++)
            {
                if (batteryCapacities[i] > 0)
                {
                    Console.WriteLine($"Battery {i + 1}: {batteryCapacities[i]:f2} mAh ({((batteryCapacities[i] /(batteryCapacities[i] + streeeTestHours * usagePerHour[i])) * 100):f2})%");
                }
                else
                {
                    Console.WriteLine($"Battery {i + 1}: dead (lasted {batteryLasts[i]} hours)");
                }
            }
        }
    }
}
