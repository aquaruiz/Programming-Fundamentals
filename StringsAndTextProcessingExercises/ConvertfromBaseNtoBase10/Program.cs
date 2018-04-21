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

            int baseToConvertFrom = int.Parse(input[0]);
            BigInteger baseNNumber = BigInteger.Parse(input[1]);

            BigInteger result = 0;
            long pow = 0;

            while (baseNNumber > 0)
            {
                BigInteger lastDigit = baseNNumber % 10;
                BigInteger powToPow = 1;

                //if (pow == 0)
                //{
                //    powToPow = 1;
                //}
                //else
                //{
                for (int i = 0; i < pow; i++)
                {
                    powToPow *= baseToConvertFrom;
                }
                //}

                result += lastDigit * powToPow;
                baseNNumber = baseNNumber / 10;
                pow++;
            }

            Console.WriteLine(result);
        }
    }
}
