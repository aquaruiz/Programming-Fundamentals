using System;
using System.Linq;

namespace NthDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int backwardsIndex = int.Parse(Console.ReadLine());

            int foundDigit = FindNthDigit(number, backwardsIndex);
            Console.WriteLine(foundDigit);
        }

        static int FindNthDigit(int number, int backwardsIndex)
        {
            int index = number.ToString().Length - backwardsIndex;
            char[] numberCharArray = number.ToString().ToCharArray();
            int[] numberIntArray = numberCharArray.Select(s => int.Parse(s.ToString())).ToArray();

            return numberIntArray[index];
        }
    }
}
