using System;
using System.Collections.Generic;
using System.Linq;

namespace ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] collection = Console.ReadLine().Split().Select(int.Parse).ToArray();
            List<int> input = collection.ToList();

            string command = Console.ReadLine();

            while (command != "print")
            {
                List<string> commands = command.Split().ToList();

                string action = commands[0];

                if (action == "add")
                {
                    int index = int.Parse(commands[1]);
                    int element = int.Parse(commands[2]);

                    input.Insert(index, element);
                }
                else if (action == "addMany")
                {
                    int index = int.Parse(commands[1]);
                    commands.RemoveAt(0);
                    commands.RemoveAt(0);
                    List<int> elements = commands.Select(int.Parse).ToList();

                    for (int i = 0; i < elements.Count; i++)
                    {
                        input.Insert(index, elements[i]);
                        index++;
                    }
                }
                else if (action == "contains")
                {
                    int element = int.Parse(commands[1]);
                    if (input.Contains(element))
                    {
                        for (int i = 0; i < input.Count; i++)
                        {
                            if (input[i] == element)
                            {
                                Console.WriteLine(i);
                                break;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("-1");
                    }
                }
                else if (action == "remove")
                {
                    int index = int.Parse(commands[1]);

                    input.RemoveAt(index);
                }
                else if (action == "shift")
                {
                    int numberShifts = int.Parse(commands[1]);
                    Shifs(numberShifts, input);
                }
                else if(action == "sumPairs")
                {
                    for (int i = 0; i < input.Count - 1; i++)
                    {
                        input[i] = input[i] + input[i + 1];
                        input.RemoveAt(i + 1);
                    }
                }

                command = Console.ReadLine();
            }

            if (command == "print")
            {
                Console.WriteLine("[" + string.Join(", ", input) + "]");
            }
        }

        static void Shifs(int numberShifts, List<int> input)
        {
            if (numberShifts > input.Count)
            {
                numberShifts = numberShifts % input.Count;
            }

            for (int i = 0; i < numberShifts; i++)
            {
                int firstelement = input[0];

                for (int j = 0; j < input.Count - 1; j++)
                {
                    input[j] = input[j + 1];
                }

                input[input.Count - 1] = firstelement;
            }
        }
    }
}
