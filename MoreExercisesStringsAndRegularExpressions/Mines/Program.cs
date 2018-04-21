using System;
using System.Collections.Generic;
using System.Linq;

namespace Mines
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> mineLine = Console.ReadLine().ToCharArray().ToList();

            while (mineLine.Contains('<') && mineLine.Contains('>'))
            {
                int index = mineLine.IndexOf('<');
                int mineStartIndex = index + 1;
                int mineEndIndex = index + 2;
                char mineFirstLetter = mineLine[mineStartIndex];
                char mineSecondLetter = mineLine[mineEndIndex];
                int minePower = Math.Abs(mineFirstLetter - mineSecondLetter);

                int blastAwayStartIndex = index - minePower;
                int blastAwayEndIndex = index - 1 + 4 + minePower;

                if (blastAwayStartIndex < 0)
                {
                    blastAwayStartIndex = 0;
                }

                if (blastAwayEndIndex >= mineLine.Count)
                {
                    blastAwayEndIndex = mineLine.Count - 1;
                }

                for (int i = blastAwayStartIndex; i <= blastAwayEndIndex; i++)
                {
                    mineLine.RemoveAt(i);
                    mineLine.Insert(i, '_');
                }
            }

            Console.WriteLine(string.Join("", mineLine));
        }
    }
}
