using System;

namespace VariableInHexadecimalFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var number = Convert.ToInt32(input, 16);
            Console.WriteLine(number);
        }
    }
}
