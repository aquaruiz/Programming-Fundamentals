using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Trainegram
{
    class Program
    {
        static void Main(string[] args)
        {
            string locomotive = "<\\[[^0-9a-zA-Z]*?]\\.";
            string wagon = "\\.\\[\\w*?]\\.";

            string input = Console.ReadLine();
            List<string> foundTrains = new List<string>();

            while (input != "Traincode!")
            {
                MatchCollection locomotiveWannabe = Regex.Matches(input, locomotive);

                if (locomotiveWannabe.Count > 1 || locomotiveWannabe.Count == 0)
                {
                    input = Console.ReadLine();
                    continue;
                }

                string loco = "";

                foreach (Match locomo in locomotiveWannabe)
                {
                    loco = locomo.Value;
                }

                if (!input.StartsWith(loco))
                {
                    input = Console.ReadLine();
                    continue;
                }

                MatchCollection wagonsWannabe = Regex.Matches(input, wagon);

                if (wagonsWannabe.Count > 0)
                {
                    string lastWagon = wagonsWannabe[wagonsWannabe.Count - 1].Value;

                    if (!input.EndsWith(lastWagon))
                    {
                        input = Console.ReadLine();
                        continue;
                    }
                }else
                {
                    if (!input.EndsWith(loco))
                    {
                        input = Console.ReadLine();
                        continue;
                    }
                }

                foundTrains.Add(input);
                input = Console.ReadLine();
            }

            foreach (var train in foundTrains)
            {
                Console.WriteLine(train);
            }
        }
    }
}
