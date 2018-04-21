using System;

namespace DNASequences
{
    class Program
    {
        static void Main(string[] args)
        {
            int matchSum = int.Parse(Console.ReadLine());
            string match = "X";

            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    for (int k = 1; k <= 4; k++)
                    {

                        if (i + j + k >= matchSum)
                        {
                            match = "O";
                        }
                        else
                        {
                            match = "X";
                        }


                        Console.Write($"{match}{i}{j}{k}{match} ".Replace('1', 'A').Replace('2', 'C').Replace('3', 'G').Replace('4', 'T'));
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
