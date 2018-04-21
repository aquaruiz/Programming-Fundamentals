using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HornetComm
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string privateMessagePattern = @"^([0-9]+) <-> ([0-9a-zA-Z]+)$";
            string broadcastPattern = @"^([^0-9]+) <-> ([0-9a-zA-Z]+)$";
            List<string> privateMessages = new List<string>();
            List<string> broadcasts = new List<string>();

            while (input != "Hornet is Green")
            {
                Match privateMess = Regex.Match(input, privateMessagePattern);

                if (privateMess.Success)
                {
                    privateMessages.Add(input);
                }

                Match broadc = Regex.Match(input, broadcastPattern);

                if (broadc.Success)
                {
                    broadcasts.Add(input);
                }

                input = Console.ReadLine();
            }

            List <string> decryptedPrivateMessages = new List<string>();
            List<string> decryptedBroadcasts = new List<string>();

            foreach (var message in privateMessages)
            {
                string[] current = message.Split(" <-> ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                char[] currentRecipientCode = current[0].Reverse().ToArray();
                decryptedPrivateMessages.Add(string.Join("", currentRecipientCode).Trim() + " -> " + current[1]);
            }

            foreach (var broadcast in broadcasts)
            {
                string[] current = broadcast.Split(" <-> ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string frequency = current[1];

                for (int i = 0; i < frequency.Length; i++)
                {
                    if (frequency[i] >= 65 && frequency[i] <= 90)
                    {
                        frequency = frequency.Replace(frequency[i], (char)(frequency[i] + 32));
                    }
                    else if (frequency[i] >= 97 && frequency[i] <= 122)
                    {
                        frequency = frequency.Replace(frequency[i], (char)(frequency[i] - 32));
                    }
                }

                decryptedBroadcasts.Add(frequency.Trim() + " -> " + current[0]);
            }

            Console.WriteLine("Broadcasts:");
            if (decryptedBroadcasts.Count > 0)
            {
                foreach (var broadcast in decryptedBroadcasts)
                {
                    Console.WriteLine(broadcast);
                }
            }
            else
            {
                Console.WriteLine("None");
            }

            Console.WriteLine("Messages:");
            if (decryptedPrivateMessages.Count > 0)
            {
                foreach (var message in decryptedPrivateMessages)
                {
                    Console.WriteLine(message);
                }
            }
            else
            {
                Console.WriteLine("None");
            }            
        }
    }
}
