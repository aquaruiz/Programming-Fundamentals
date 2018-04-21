using System;

namespace WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int waterTankCapacity = 255;
            int numberLines = int.Parse(Console.ReadLine());
            int usedCapacity = 0;

            for (int i = 0; i < numberLines; i++)
            {
                int waterQnty = int.Parse(Console.ReadLine());
                if (waterQnty <= waterTankCapacity)
                {
                    usedCapacity += waterQnty;
                    waterTankCapacity -= waterQnty;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
            }

            Console.WriteLine(usedCapacity);
        }
    }
}
