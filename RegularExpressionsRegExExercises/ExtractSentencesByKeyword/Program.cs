using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ExtractSentencesByKeyword
{
    class Program
    {
        private static object regex;

        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string[] sentence = Console.ReadLine().Split(".!?".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            string pattern = @".*\b" + word + @"\b.*";

            Match matchedSentence;
            List<string> matchedOutput = new List<string>();

            for (int i = 0; i < sentence.Length; i++)
            {
                matchedSentence = Regex.Match(sentence[i], pattern);
                if (matchedSentence.ToString() != "")
                {
                    matchedOutput.Add(matchedSentence.ToString());
                }
            }

            foreach (var sentance in matchedOutput)
            {
                Console.WriteLine(sentance);
            }
        }
    }
}
