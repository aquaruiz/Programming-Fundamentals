using System;
using System.Collections.Generic;
using System.Linq;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = Console.ReadLine();

            while (command != "Odd" && command != "Even")
            {
                List<string> actions = command.Split().ToList();

                if (actions[0] == "Delete")
                {
                    int elementsToDelete = int.Parse(actions[1]);
                    input.RemoveAll(element => element == elementsToDelete);
                }
                else if (actions[0] == "Insert")
                {
                    int elementToInsert = int.Parse(actions[1]);
                    int position = int.Parse(actions[2]);

                    input.Insert(position, elementToInsert);
                }

                command = Console.ReadLine();
            }

            if (command == "Odd")
            {
                for (int i = 0; i < input.Count; i++)
                {
                    if (input[i] % 2 == 1)
                    {
                        Console.Write($"{input[i]} ");
                    }
                }
            }
            else if (command == "Even")
            {
                for (int i = 0; i < input.Count; i++)
                {
                    if (input[i] % 2 == 0)
                    {
                        Console.Write($"{input[i]} ");
                    }
                }
            }
        }
    }
}
