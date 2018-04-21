using System;

namespace BooleanVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            try
            {
                var isBool = Boolean.Parse(input);
                if (isBool)
                {
                    Console.WriteLine("Yes");
                }
                else
                {
                    Console.WriteLine("No");
                }
            }
            catch
            {
            }           
        }
    }
}
