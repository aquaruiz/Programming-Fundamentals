using System;

namespace FastPrimeCheckerRefactor
{
    class Program
    {
        static void Main(string[] args)
        {
            int range = int.Parse(Console.ReadLine());
            for (int i = 2; i <= range; i++)
            {
                bool isPrime = true;
                for (int devider = 2; devider <= Math.Sqrt(i); devider++)
                {
                    if (i % devider == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                Console.WriteLine($"{i} -> {isPrime}");
            }
        }
    }
}
