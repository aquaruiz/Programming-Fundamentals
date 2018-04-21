using System;
using System.Linq;

namespace Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] phoneNumbers = Console.ReadLine().Split().ToArray();
            string[] names = Console.ReadLine().Split().ToArray();

            string input = Console.ReadLine();

            while (input != "done")
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if (input == names[i])
                    {
                        Console.WriteLine("{0} -> {1}", names[i], phoneNumbers[i]);
                    }
                }

                input = Console.ReadLine();
            }
        }
    }
}
