using System;
using System.Collections.Generic;
using System.Linq;

namespace TrackDownloader
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> blacklistedWords = Console.ReadLine().Split().ToList();
            List<string> downloadedSongs = new List<string>();

            string command = Console.ReadLine();

            while (command != "end")
            {
                bool banned = false;

                for (int i = 0; i < blacklistedWords.Count; i++)
                {
                    if (command.Contains(blacklistedWords[i]))
                    {
                        banned = true;
                    }
                }

                if (!banned)
                {
                    downloadedSongs.Add(command);
                }

                command = Console.ReadLine();
            }

            downloadedSongs.Sort();

            for (int i = 0; i < downloadedSongs.Count; i++)
            {
                Console.WriteLine(downloadedSongs[i]);
            }
        }
    }
}
