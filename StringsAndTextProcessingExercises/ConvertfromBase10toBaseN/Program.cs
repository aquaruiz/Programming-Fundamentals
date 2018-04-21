using System;
using System.Linq;
using System.Numerics;

namespace ConvertfromBase10toBaseN
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();

            int baseToConvertTo = int.Parse(input[0]);
            BigInteger base10Number = BigInteger.Parse(input[1]);

            string result = string.Empty;

            while (base10Number > 0)
            {
                BigInteger reminder = base10Number % baseToConvertTo;
                result += reminder;
                base10Number = base10Number / baseToConvertTo;
            }

            Console.WriteLine(string.Join("", result.Reverse()));
        }
    }
}
