using System;

namespace StringEncryption
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string result = string.Empty;

            for (int i = 0; i < number; i++)
            {
                char input = char.Parse(Console.ReadLine());
                result += Encrypt(input);
            }

            Console.WriteLine(result);
        }

        static string Encrypt(char input)
        {
            int asciiCode = input;
            int firstDigitOfAsciiCode = int.Parse(asciiCode.ToString()[0].ToString());
            int lastDigitOfAsciiCode = int.Parse(asciiCode.ToString()[asciiCode.ToString().Length - 1].ToString());
            char charFirst = (char)(asciiCode + lastDigitOfAsciiCode);
            char charLast = (char)(asciiCode - firstDigitOfAsciiCode);

            return charFirst.ToString() + firstDigitOfAsciiCode.ToString() + lastDigitOfAsciiCode.ToString() + charLast.ToString();
        }
    }
}
