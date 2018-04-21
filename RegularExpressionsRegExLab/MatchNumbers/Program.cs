using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace MatchPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {

            string pattern = @"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))";
            string input = Console.ReadLine();

            MatchCollection matchedOutput = Regex.Matches(input, pattern);

            List<string> output = matchedOutput.Cast<Match>().Select(x => x.Value).ToList();

            Console.WriteLine(string.Join(" ", output));
        }
    }
}
