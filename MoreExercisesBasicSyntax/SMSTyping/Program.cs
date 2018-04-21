using System;

namespace SMSTyping
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberLines = int.Parse(Console.ReadLine());
            string message = "";

            for (int i = 0; i < numberLines; i++)
            {
                int input = int.Parse(Console.ReadLine());

                int numberOfDigits = input.ToString().Length;
                int mainDigit = input % 10;
                int offset = (mainDigit - 2) * 3;

                if (mainDigit == 8 || mainDigit == 9)
                {
                    offset++;
                }

                int letterIndex = (offset + numberOfDigits) - 1;
                if (input == 0)
                {
                    message += " ";
                }
                else
                {
                    char letter = (char)(97 + letterIndex);
                    message += letter;
                }                
            }

            Console.WriteLine(message);
        }
    }
}
