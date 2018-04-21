using System;

namespace VowelOrDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = char.Parse(Console.ReadLine());

            if (input == 'a'
                || input == 'o'
                || input == 'e'
                || input == 'u'
                || input == 'i')
            {
                Console.WriteLine("vowel");
            }
            else if (input >= '0' && input <= '9')
            {
                Console.WriteLine("digit");
            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}
