using System;
using System.Collections.Generic;
using System.Linq;

namespace SafeManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();
            string command = Console.ReadLine();

            while (command != "END")
            {
                string action = command.Split().ToArray()[0];

                if (action == "Reverse")
                {
                    input = input.Reverse().ToArray();
                }
                else if (action == "Distinct")
                {
                    input = input.Distinct().ToArray();
                }
                else if (action == "Replace")
                {
                    int index = int.Parse(command.Split().ToArray()[1]);
                    string element = command.Split().ToArray()[2];

                    if (index > input.Length - 1 || index < 0)
                    {
                        Console.WriteLine("Invalid input!");
                    }
                    else
                    {
                        List<string> newlist = input.ToList();
                        newlist.RemoveAt(index);
                        newlist.Insert(index, element);
                        input = newlist.ToArray();
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", input));

        }
    }
}
