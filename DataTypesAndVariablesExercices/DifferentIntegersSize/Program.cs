using System;

namespace DifferentIntegersSize
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            try
            {
                long number = long.Parse(input);
                string message = "";
                if (number>= sbyte.MinValue && number <= sbyte.MaxValue)
                    message += "* sbyte \n";
                if(number >= byte.MinValue && number <= byte.MaxValue)
                    message += "* byte \n";
                if (number >= short.MinValue && number <= short.MaxValue)
                    message += "* short \n";
                if (number >= ushort.MinValue && number <= ushort.MaxValue)
                    message += "* ushort \n";
                if (number >= int.MinValue && number <= int.MaxValue)
                    message += "* int \n";
                if (number >= uint.MinValue && number <= uint.MaxValue)
                    message += "* uint \n";
                if (number >= long.MinValue && number <= long.MaxValue)
                    message += "* long";

                Console.WriteLine("{0} can fit in:", number);
                Console.WriteLine(message);
            }
            catch
            {
                Console.WriteLine("{0} can't fit in any type", input);
            }
        }
    }
}
