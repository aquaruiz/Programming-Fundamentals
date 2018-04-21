using System;
using System.Collections.Generic;
using System.Linq;

namespace Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            Dictionary<string, string> phonebook = new Dictionary<string, string>();

            while (input[0] != "END")
            {
                string command = input[0];
                string name;
                string phone;
                if (command == "A")
                {
                    name = input[1];
                    phone = input[2];
                    phonebook[name] = phone;
                }
                else if (command == "S")
                {
                    name = input[1];
                    if (phonebook.ContainsKey(name))
                    {
                        Console.WriteLine($"{name} -> {phonebook[name]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {name} does not exist.");
                    }
                }
                else if (command == "ListAll")
                {
                    foreach (var kvp in phonebook.OrderBy(x => x.Key))
                    {
                        Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
                    }
                }

                input = Console.ReadLine().Split();
            }
        }
    }
}
