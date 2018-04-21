using System;
using System.Linq;

namespace Icarus
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] planes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int startPosition = int.Parse(Console.ReadLine());
            int damage = 1;
            int endPosition = startPosition;

            string command = Console.ReadLine();

            while (command != "Supernova")
            {
                string direction = command.Split()[0];
                int step = int.Parse(command.Split()[1]);

                if (direction == "left")
                {
                    endPosition = startPosition - step;

                    for (int i = startPosition - 1; i >= endPosition; i--)
                    {
                        if (i < 0)
                        {
                            damage++;
                            startPosition = planes.Length - 1;
                            i = startPosition;
                            endPosition = planes.Length + endPosition;
                        }

                        planes[i] -= damage;
                    }

                    startPosition = endPosition;
                }
                else if (direction == "right")
                {
                    endPosition = startPosition + step;

                    for (int i = startPosition + 1; i <= endPosition; i++)
                    {
                        if (i > planes.Length - 1)
                        {
                            damage++;
                            startPosition = 0;
                            i = startPosition;
                            endPosition = endPosition - planes.Length;
                        }

                        planes[i] -= damage;
                    }

                    startPosition = endPosition;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", planes));
        }
    }
}
