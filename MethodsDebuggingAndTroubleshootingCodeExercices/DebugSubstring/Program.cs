using System;

namespace DebugSubstring
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int offset = int.Parse(Console.ReadLine());

            const char Search = 'p';
            bool hasMatch = false;
            string matchedString = "";            

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == Search)
                {
                    hasMatch = true;
                    int matchedStringLength = offset + 1;

                    if (matchedStringLength + i > text.Length - 1)
                    {
                        matchedStringLength = text.Length - i;
                    }

                    matchedString = text.Substring(i, matchedStringLength);
                    Console.WriteLine(matchedString);
                    i += offset;
                }
            }

            if (!hasMatch)
            {
                Console.WriteLine("no");
            }
        }
    }
}