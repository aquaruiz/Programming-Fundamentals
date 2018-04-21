using System;
using System.Text.RegularExpressions;

namespace KeyReplacer
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] key = Console.ReadLine().Split("|<\\".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            string text = Console.ReadLine();

            string keyStart = key[0];
            string keyEnd = key[key.Length - 1];

            string pattern = keyStart + @"(.*?)" + keyEnd;
            string output = string.Empty;

            MatchCollection mathes = Regex.Matches(text, pattern);

            foreach (Match match in mathes)
            {
                output += match.Groups[1].Value;
            }

            if (output == string.Empty)
            {
                Console.WriteLine("Empty result");
            }
            else
            {
                Console.WriteLine(output);
            }
        }
    }
}
