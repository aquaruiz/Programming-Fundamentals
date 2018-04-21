using System;
using System.Text.RegularExpressions;

namespace Regexmon
{
    class Program
    {
        static void Main(string[] args)
        {
            string bojomonPattern = @"[a-zA-Z]+-[a-zA-Z]+";
            string didimonPattern = @"[^a-zA-Z-]+";

            string input = Console.ReadLine();
            bool DidimonTurn = true;
            bool bojomonTurn = false;
            int startIndex = 0;
            string strToSearchIn = input;

            while (startIndex < input.Length)
            {
                string patternToMatch = string.Empty;

                if (DidimonTurn == true)
                {
                    DidimonTurn = false;
                    bojomonTurn = true;
                    patternToMatch = didimonPattern;
                }
                else                
                {
                    DidimonTurn = true;
                    bojomonTurn = false;
                    patternToMatch = bojomonPattern;
                }

                var match = Regex.Match(strToSearchIn, patternToMatch);
                startIndex = match.Index + match.Length;

                if (match.Success)
                {
                    Console.WriteLine(match.Value);
                    strToSearchIn = strToSearchIn.Substring(startIndex);
                }
                else
                {
                    return;
                }
            }
        }
    }
}
