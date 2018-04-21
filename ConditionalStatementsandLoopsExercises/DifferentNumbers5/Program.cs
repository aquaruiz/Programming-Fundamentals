using System;

namespace DifferentNumbers5
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());

            bool isTrue = false;

            for (int i = numberOne; i <= numberTwo; i++)
            {
                for (int j = numberOne; j <= numberTwo; j++)
                {
                    for (int k = numberOne; k <= numberTwo; k++)
                    {
                        for (int l = numberOne; l <= numberTwo; l++)
                        {
                            for (int m = numberOne; m <= numberTwo; m++)
                            {
                                if (i < j && j < k && k < l && l < m)
                                {
                                    Console.WriteLine($"{i} {j} {k} {l} {m}");
                                    isTrue = true;
                                }
                            }
                        }
                    }
                }
            }

            if (!isTrue)
            {
                Console.WriteLine("No");
            }
        }
    }
}
