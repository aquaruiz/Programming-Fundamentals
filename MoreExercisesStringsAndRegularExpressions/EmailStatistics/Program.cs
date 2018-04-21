using System;
using System.Collections.Generic;
using System.Linq;

namespace EmailStatistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> emails = new Dictionary<string, List<string>>();
            bool isEmailValid = true;

            for (int i = 0; i < n; i++)
            {
                string emailWannabe = Console.ReadLine();

                if (!emailWannabe.Contains("@") 
                    || !emailWannabe.Contains(".") 
                    || emailWannabe.Contains("_") 
                    || emailWannabe.Contains(" ") 
                    || emailWannabe.Contains("\t")
                    )
                {
                    isEmailValid = false;
                }

                string username = string.Empty;
                string mailServer = string.Empty;
                string domain = string.Empty;
                int indexOfAt = emailWannabe.IndexOf('@');
                int indexOfDot = emailWannabe.IndexOf('.');

                for (int j = 0; j < indexOfAt; j++)
                {
                    username += emailWannabe[j];
                }

                for (int j = indexOfAt + 1; j < indexOfDot; j++)
                {
                    mailServer += emailWannabe[j];
                }

                for (int j = indexOfDot + 1; j < emailWannabe.Length; j++)
                {
                    domain += emailWannabe[j];
                }

                // username validity
                if (username.Length < 5)
                {
                    isEmailValid = false;
                }

                for (int j = 0; j < username.Length; j++)
                {
                    if (!((username[j] >= 'a' && username[j] <= 'z') 
                        || (username[j] >= 'A' && username[j] <= 'Z')))
                    {
                        isEmailValid = false;
                    }
                }

                //mailServer validity
                if (mailServer.Length < 3)
                {
                    isEmailValid = false;
                }

                for (int j = 0; j < mailServer.Length; j++)
                {
                    if (!(mailServer[j] >= 'a' && mailServer[j] <= 'z'))
                    {
                        isEmailValid = false;
                    }
                }

                //domain validity
                if (domain != "com"
                    && domain != "bg"
                    && domain != "org"
                    )
                {
                    isEmailValid = false;
                }

                if (isEmailValid)
                {
                    if (!(emails.ContainsKey(mailServer + "." + domain)))
                    {
                        List<string> users = new List<string>();
                        users.Add(username);
                        emails.Add((mailServer + "." + domain), users);
                    }
                    else
                    {
                        if (!emails[mailServer + "." + domain].Contains(username))
                        {
                            emails[mailServer + "." + domain].Add(username);
                        }
                    }
                }    
                else
                {
                    isEmailValid = true;
                }
            }

            foreach (KeyValuePair<string, List<string>> usernamesDomains in emails.OrderByDescending(x => x.Value.Count()))
            {
                Console.WriteLine(usernamesDomains.Key + ":");

                foreach (var user in usernamesDomains.Value)
                {
                    Console.WriteLine("### " + user);
                }
            }
        }
    }
}
