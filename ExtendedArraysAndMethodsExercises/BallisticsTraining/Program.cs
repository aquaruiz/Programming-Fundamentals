using System;
using System.Linq;

namespace Altitude
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] planeCoordinates = Console.ReadLine().Split().Select(double.Parse).ToArray();
            double planeX = planeCoordinates[0];
            double planeY = planeCoordinates[1];

            string[] commands = Console.ReadLine().Split().ToArray();

            double initialX = 0;
            double initialY = 0;

            for (int i = 0; i < commands.Length - 1; i++)
            {
                string direction = commands[i];
                double distance = double.Parse(commands[++i]);

                if (direction == "up")
                {
                    initialY += distance;
                }
                else if (direction == "down")
                {
                    initialY -= distance;
                }
                else if (direction == "left")
                {
                    initialX -= distance;
                }
                else if (direction == "right")
                {
                    initialX += distance;
                }
            }

            Console.WriteLine($"firing at [{initialX}, {initialY}]");

            if (initialX == planeX && initialY == planeY)
            {
                Console.WriteLine("got 'em!");
            }
            else
            {
                Console.WriteLine("better luck next time...");
            }
        }
    }
}
