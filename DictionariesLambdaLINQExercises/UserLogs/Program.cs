using System;
using System.Collections.Generic;
using System.Linq;

namespace UserLogs
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, Dictionary<string, int>> userIpLogs = new Dictionary<string, Dictionary<string, int>>();

            while (input != "end")
            {
                string[] command = input.Split().ToArray();
                string ipAddress = command[0].Split('=')[1];
                string username = command[2].Split('=')[1];
                Dictionary<string, int> ipLogQnty = new Dictionary<string, int>();

                if (!userIpLogs.ContainsKey(username))
                {
                    ipLogQnty.Add(ipAddress, 1);
                    userIpLogs.Add(username, ipLogQnty);
                }
                else
                {
                    if (!userIpLogs[username].ContainsKey(ipAddress))
                    {
                        userIpLogs[username].Add(ipAddress, 1);
                    }
                    else
                    {
                        userIpLogs[username][ipAddress]++; 
                    }
                }

                input = Console.ReadLine();
            }

            List<string> output = new List<string>();

            foreach (var userIP in userIpLogs.OrderBy(x => x.Key))
            {
                Console.WriteLine("{0}:", userIP.Key);
                foreach (var ip in userIP.Value)
                {
                    output.Add($"{ip.Key} => {ip.Value}");
                }
                Console.WriteLine(string.Join(", ", output) + ".");
                output.Clear();
            }
        }
    }
}
