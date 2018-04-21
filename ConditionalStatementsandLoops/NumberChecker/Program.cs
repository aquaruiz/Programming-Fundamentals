using System;

namespace NumberChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var output = 0;
            try
            {
                output = int.Parse(input);
                Console.WriteLine("It is a number.");
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input!");
            }
        }
    }
}
