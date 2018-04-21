using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace AnonymousVox
{
    class Program
    {
        static void Main(string[] args)
        {
            string encodedText = Console.ReadLine();
            List<string> placeholders = Console.ReadLine().Split("{}".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToList();

            string placeholdersBlocks = @"(?<start>[a-zA-Z]+)(?<middle>.+)(\k<start>)";

            MatchCollection placeholdsInEncodedText = Regex.Matches(encodedText, placeholdersBlocks);

            string decryptedText = encodedText;
            int count = 0;

            foreach(Match placeho in placeholdsInEncodedText)
            {
                decryptedText = decryptedText.Replace(placeho.Groups["middle"].Value, placeholders[count]);
                count++;
            }

            Console.WriteLine(decryptedText);
        }
    }
}
