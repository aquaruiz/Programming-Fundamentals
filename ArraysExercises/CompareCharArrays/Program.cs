using System;
using System.Linq;

namespace CompareCharArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] collection1 = Console.ReadLine().Split().Select(char.Parse).ToArray();
            char[] collection2 = Console.ReadLine().Split().Select(char.Parse).ToArray();

            bool isSameFirstLetters = false;

            for (int i = 0; i < Math.Min(collection1.Length, collection2.Length); i++)
            {
                if (collection1[i] == collection2[i])
                {
                    isSameFirstLetters = true;
                    continue;
                }
                else
                {
                    break;
                }
            }

            if (!isSameFirstLetters)
            {
                if (collection1[0] > collection2[0])
                {
                    Console.WriteLine(string.Join("", collection2));
                    Console.WriteLine(string.Join("", collection1));
                }
                else
                {
                    Console.WriteLine(string.Join("", collection1));
                    Console.WriteLine(string.Join("", collection2));
                }

            }
            else
            {
                if (collection1.Length < collection2.Length)
                {
                    Console.WriteLine(string.Join("", collection1));
                    Console.WriteLine(string.Join("", collection2));
                }
                else
                {
                    Console.WriteLine(string.Join("", collection2));
                    Console.WriteLine(string.Join("", collection1));
                }
            }
        }
    }
}
