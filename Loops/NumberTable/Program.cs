using System;

namespace NumberTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    int num = row + col + 1;
                    Console.Write(num + " ");

                    if (num >= n)
                    {
                        for (int k = 0; k <= n - col - 2; k++)
                        {
                            Console.Write(2 * n - num - 1 + " ");
                            num++;
                        }

                        break;
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
