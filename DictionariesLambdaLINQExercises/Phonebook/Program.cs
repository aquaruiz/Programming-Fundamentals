using System;
using System.Collections.Generic;

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
                string name = input[1];
                string phone;
                if (command == "A")
                {
                    phone = input[2];
                    phonebook[name] = phone;
                }
                else if (command == "S")
                {
                    if (phonebook.ContainsKey(name))
                    {
                        Console.WriteLine($"{name} -> {phonebook[name]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {name} does not exist.");
                    }

                }

                input = Console.ReadLine().Split();
            }
        }
    }
}
