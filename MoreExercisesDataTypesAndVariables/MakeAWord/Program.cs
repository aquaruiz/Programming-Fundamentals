using System;

namespace MakeAWord
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string word = "";

            for (int i = 0; i < number; i++)
            {
                char character = char.Parse(Console.ReadLine());
                word += character;
            }
            Console.WriteLine("The word is: {0}", word);
        }
    }
}
