using System;
using System.Collections.Generic;
using System.Linq;

namespace ShootListElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<int> output = new List<int>();
            int lastRemovedInt = 0;

            while (input != "stop")
            {
                try
                {
                    int number = int.Parse(input);
                    output.Insert(0, number);
                }
                catch
                {
                    if (output.Count == 0)
                    {
                        Console.WriteLine("nobody left to shoot! last one was {0}", lastRemovedInt);
                        return;
                    }

                    double av = output.Average();

                    if (output.Count == 1)
                    {
                        Console.WriteLine("shot {0}", output[0]);
                        lastRemovedInt = output[0];
                        output.RemoveAt(0);
                    }

                    for (int i = 0; i < output.Count; i++)
                    {
                        if (output[i] < av)
                        {
                            Console.WriteLine("shot {0}", output[i]);
                            lastRemovedInt = output[i];
                            output.RemoveAt(i);
                            break;
                        }
                    }

                    for (int i = 0; i < output.Count; i++)
                    {
                        output[i]--;
                    }
                }

                input = Console.ReadLine();
            }

            if (output.Count > 0)
            {
                Console.WriteLine("survivors: " + string.Join(" ", output));
            }
            else
            {
                Console.WriteLine("you shot them all. last one was {0}", lastRemovedInt);
            }
        }
    }
}
