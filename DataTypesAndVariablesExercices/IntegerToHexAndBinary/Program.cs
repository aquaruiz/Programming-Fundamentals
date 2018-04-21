using System;

namespace IntegerToHexAndBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            var outputHexe = Convert.ToString(input, 16).ToUpper();
            string outputBin = Convert.ToString(input, 2);

            Console.WriteLine(outputHexe);
            Console.WriteLine(outputBin);
        }
    }
}
