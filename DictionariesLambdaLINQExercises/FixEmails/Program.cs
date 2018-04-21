using System;
using System.Collections.Generic;

namespace AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, string> mailList = new Dictionary<string, string>();

            while (input != "stop")
            {
                string name = input;
                string email = Console.ReadLine();

                if (!mailList.ContainsKey(name))
                {
                    if (!email.EndsWith("us") && !email.EndsWith("uk"))
                    {
                        mailList[name] = email;
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var nameMail in mailList)
            {
                Console.WriteLine($"{nameMail.Key} -> {nameMail.Value}");
            }
        }
    }
}
