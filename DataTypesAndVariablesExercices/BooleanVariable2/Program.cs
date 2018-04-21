using System;

namespace BooleanVariable2
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            bool isBool = Convert.ToBoolean(input);

            if (isBool)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
        }
    }
}
