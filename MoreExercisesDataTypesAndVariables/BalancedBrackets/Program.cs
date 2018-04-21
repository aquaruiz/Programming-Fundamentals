using System;

namespace BalancedBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            string openClosed = "open";
            int open = 0;
            int closed = 0;

            for (int i = 0; i < number; i++)
            {
                string input = Console.ReadLine();
                if (input == "(")
                {
                    open++;
                    openClosed = "open";
                }
                else if (input == ")")
                {
                    closed++;
                    openClosed = "closed";
                }
            }

            if (open == closed && open != 0 && closed != 0 && openClosed == "closed")
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}
