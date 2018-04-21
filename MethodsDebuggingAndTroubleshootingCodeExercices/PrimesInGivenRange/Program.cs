using System;
using System.Collections.Generic;

namespace PrimesInGivenRange
{
    class Program
    {
        static void Main(string[] args)
        {
            long startNumber = long.Parse(Console.ReadLine());
            long endNumber = long.Parse(Console.ReadLine());
            var outputNumbers = FindPrimesInRange(startNumber, endNumber);
            string output = string.Join(", ", outputNumbers);
            
            Console.WriteLine(output);
        }
        static List<long> FindPrimesInRange(long startNum, long endNum)
        {
            List<long> primes = new List<long>();
            bool isPrime = true;
            
            for (long number = startNum; number <= endNum; number++)
            {
                for (int devider = 2; devider <= Math.Sqrt(number); devider++)
                {
                    if (number % devider == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime && number >= 2)
                {
                    primes.Add(number);
                }

                isPrime = true;
            }

            return primes;
        }
    }
}
