using System;
using System.Linq;

namespace Altitude
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] commands = Console.ReadLine().Split().ToArray();

            double initialAltitude = double.Parse(commands[0]);
            double currentAltitude = initialAltitude;

            for (int i = 1; i < commands.Length; i++)
            {
                string direction = commands[i].ToLower();
                double distance = double.Parse(commands[++i]);
                
                if (direction == "up")
                {
                    currentAltitude += distance;   
                }
                else if (direction == "down")
                {
                    currentAltitude -= distance;
                }

                if (currentAltitude <= 0)
                {
                    Console.WriteLine("crashed");
                    return;
                }
            }

            Console.WriteLine("got through safely. current altitude: {0}m", currentAltitude);
        }
    }
}
