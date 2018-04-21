using System;
using System.Collections.Generic;
using System.Linq;

namespace ManipulateArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                string command = Console.ReadLine();

                if (command == "Reverse")
                {
                    input = input.Reverse().ToArray();
                }
                else if (command == "Distinct")
                {
                    input = input.Distinct().ToArray();
                }
                else
                {
                    string[] commandLine = command.Split().ToArray();
                    int index = int.Parse(commandLine[1]);
                    string element = commandLine[2];

                    List<string> newlist = input.ToList();
                    newlist.RemoveAt(index);
                    newlist.Insert(index, element);
                    input = newlist.ToArray();
                }
            }

            Console.WriteLine(string.Join(", ", input));
        }
    }
}
