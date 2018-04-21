using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace UseYourChainsBuddy
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string stripTags = @"(?<=<p>).*?(?=<\/p>)";
            string innerPattern = @"[^a-z0-9]";
            StringBuilder sb = new StringBuilder();

            MatchCollection stringsWithoutTags = Regex.Matches(input, stripTags);

            foreach (Match str in stringsWithoutTags)
            {
                string withoutStrangeSymbols = Regex.Replace(str.ToString(), innerPattern, " ");
                sb.Append(withoutStrangeSymbols);
            }

            StringBuilder output = new StringBuilder();

            foreach (var letter in sb.ToString())
            {
                char ch = letter;

                if (letter >= 'a' && letter <= 'm')
                {
                    ch = (char)(ch + 13);
                }

                if (letter >= 'n' && letter <= 'z')
                {
                    ch = (char)(ch - 13);
                }

                output.Append(ch);
            }

            string newoutput = Regex.Replace(output.ToString(), @"\s+|\n+", " ");

            List<char> outputString = newoutput.Trim().ToCharArray().ToList();
            StringBuilder lastString = new StringBuilder();

            for (int i = 0; i < outputString.Count - 1; i++)
            {
                if (!(outputString[i] == ' ' && outputString[i + 1] == ' '))
                {
                    lastString.Append(outputString[i]);
                }
            }

            lastString.Append(outputString[outputString.Count - 1]);

            Console.WriteLine(lastString);
        }
    }
}
