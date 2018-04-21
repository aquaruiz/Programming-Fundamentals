using System;
using System.Linq;

namespace CharRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] letters = Console.ReadLine().ToCharArray();
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < letters.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    letters[i] = (char)((int)letters[i] - numbers[i]);
                }
                else
                {
                    letters[i] = (char)(letters[i] + numbers[i]);
                }
            }

            Console.WriteLine(string.Join("", letters));
        }
    }
}
