using System;
using System.Collections.Generic;
using System.Linq;

namespace LogsAggregator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, int>> userIpDuration = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string ipAddress = input[0];
                string username = input[1];
                int duration = int.Parse(input[2]);
                Dictionary<string, int> ipDuration = new Dictionary<string, int>();

                if (!userIpDuration.ContainsKey(username))
                {
                    ipDuration.Add(ipAddress, duration);
                    userIpDuration.Add(username, ipDuration);
                }
                else
                {
                    if (!userIpDuration[username].ContainsKey(ipAddress))
                    {
                        userIpDuration[username].Add(ipAddress, duration);
                    }
                    else
                    {
                        userIpDuration[username][ipAddress] += duration;
                    }
                }
            }

            List<string> output = new List<string>();

            foreach (var userIPDuration in userIpDuration.OrderBy(x => x.Key))
            {
                Console.Write($"{userIPDuration.Key}: {userIPDuration.Value.Values.Sum()} [");
                foreach (var ipDuration in userIPDuration.Value.OrderBy(x => x.Key))
                {
                    output.Add(ipDuration.Key);
                }
                //Console.SetCursorPosition(Console.CursorLeft - 2, Console.CursorTop);
                Console.WriteLine(string.Join(", ", output) + "]");
                output.Clear();
            }
            //Console.SetCursorPosition(0, 0);
        }
    }
}
