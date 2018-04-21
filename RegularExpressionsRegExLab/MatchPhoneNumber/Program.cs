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

            string pattern = @"\+359([ |-])2\1[0-9]{3}\1[0-9]{4}\b";
            string input = Console.ReadLine();

            MatchCollection matchedOutput = Regex.Matches(input, pattern);

            List<string> output = matchedOutput.Cast<Match>().Select(x => x.Value).ToList();

            Console.WriteLine(string.Join(", ", output));
        }
    }
}
