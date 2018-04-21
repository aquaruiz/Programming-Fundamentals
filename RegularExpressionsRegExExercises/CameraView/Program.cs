using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace CameraView
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] takeSkipArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int skip = takeSkipArray[0];
            int take = takeSkipArray[1];
            string input = Console.ReadLine();
            string camera = @"\|<";
            string pattern = camera + @"(\w{" + skip + @"})(\w{0," + take + @"})";
            List<string> output = new List<string>();
            
            MatchCollection taken = Regex.Matches(input, pattern);

            foreach (Match photo in taken)
            {
                output.Add(photo.Groups[2].Value.ToString());
            }

            Console.WriteLine(string.Join(", ", output));
        }
    }
}

