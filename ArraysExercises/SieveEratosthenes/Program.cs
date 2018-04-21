using System;

namespace SieveEratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxNumber = int.Parse(Console.ReadLine());

            string[] primesCollection = new string[maxNumber + 1];

            for (int i = 0; i < primesCollection.Length; i++)
            {
                primesCollection[i] = "true";
            }

            primesCollection[0] = "false";
            primesCollection[1] = "false";

            for (int i = 0; i < primesCollection.Length; i++)
            {
                if (primesCollection[i] == "true")
                {
                    Console.Write(i + " ");

                    for (int j = 2; j <= maxNumber; j++)
                    {
                        if (i * j <= maxNumber)
                        {
                            primesCollection[j * i] = "false";
                        }
                    }
                }
            }

            Console.WriteLine();
        }
    }
}
