using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace WormIpsum
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            string wormPattern = @"[A-Z].*?[^.]\.";

            while ((input = Console.ReadLine()) != "Worm Ipsum")
            {
                Match match = Regex.Match(input, wormPattern);

                if (match.Success && match.Length == input.Length)
                {
                    string wordsReplaced = FindWordWithMoreThenOneEqualChars(match);
                    Console.WriteLine(wordsReplaced);
                }
            }
        }

        private static string FindWordWithMoreThenOneEqualChars(Match match)
        {
            string realWordPattern = @"\b\w+\b";
            Dictionary<char, int> lettersOccurances = new Dictionary<char, int>();
            string newOutput = match.Value;

            MatchCollection matches = Regex.Matches(match.ToString(), realWordPattern);

            foreach (Match word in matches)
            {
                List<char> letters = word.Value.ToCharArray().ToList();

                foreach (var letter in letters)
                {
                    if (!lettersOccurances.ContainsKey(letter))
                    {
                        lettersOccurances.Add(letter, 1);
                    }
                    else
                    {
                        lettersOccurances[letter]++;
                    }
                }

                Dictionary<char, int> OrderedLettersOccurances = lettersOccurances.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

                if (OrderedLettersOccurances.First().Value > 1)
                {
                    char letterToRepeat = OrderedLettersOccurances.First().Key;

                    string newWord = new string(letterToRepeat, word.Length);
                    newOutput = newOutput.Replace(word.Value, newWord);
                }

                lettersOccurances.Clear();
            }

            return newOutput;
        }
    }
}
