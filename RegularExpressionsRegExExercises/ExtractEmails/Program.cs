using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ExtractEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"(?<user>(?<=\s)[a-zA-Z0-9][a-zA-Z0-9\._-]*)@(?<host>([a-zA-z-][a-zA-z-0-9\.]*)\.([a-zA-Z]{2,}))";

            MatchCollection mailsWannabe = Regex.Matches(input, pattern);

            foreach (Match email in mailsWannabe)
            {
                Console.WriteLine(email.Value);
            }
        }
    }
}
