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

            string pattern = @"\b(?<day>[0-9]{2})(?<delimeter>[.\-\/ ])(?<month>[A-Z][a-z]{2})\k<delimeter>(?<year>[0-9]{4})\b";
            string input = Console.ReadLine();

            MatchCollection matchedOutput = Regex.Matches(input, pattern);

            foreach (Match date in matchedOutput)
            {
                var day = date.Groups["day"].Value;
                var month = date.Groups["month"].Value;
                var year = date.Groups["year"].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}
