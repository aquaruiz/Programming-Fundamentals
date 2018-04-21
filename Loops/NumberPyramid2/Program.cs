﻿using System;

namespace NumberPyramid2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());            
            
            int num = 1;
            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write(num + " ");
                    num++;

                    if (num == n + 1)
                    {
                        Console.WriteLine();
                        return;
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
