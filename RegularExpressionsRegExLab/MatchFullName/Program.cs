using System;
using System.Text.RegularExpressions;

namespace MatchFullName
{
    class Program
    {
        static void Main(string[] args)
        {
            string regex = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
            string input = Console.ReadLine();

            MatchCollection matchedOutput = Regex.Matches(input, regex);

            foreach (Match match in matchedOutput)
            {
                Console.Write(match.Value + " ");
            }

            Console.WriteLine();
        }
    }
}
