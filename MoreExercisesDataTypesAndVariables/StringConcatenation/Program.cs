using System;

namespace StringConcatenation
{
    class Program
    {
        static void Main(string[] args)
        {
            char delimiter = char.Parse(Console.ReadLine());
            string evenOdd = Console.ReadLine();
            int number = int.Parse(Console.ReadLine());
            string output = "";

            for (int i = 1; i <= number; i++)
            {
                string input = Console.ReadLine();
                if (evenOdd == "odd")
                {
                    if (i % 2 == 1)
                    {
                        output += input + delimiter;
                    }
                }
                else
                {
                    if (i % 2 == 0)
                    {
                        output += input + delimiter;
                    }
                }
            }

            Console.WriteLine(output.Remove(output.Length - 1));
        }
    }
}
