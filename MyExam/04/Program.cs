using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            Dictionary<string, List<string>> forces = new Dictionary<string, List<string>>();
            Dictionary<string, string> users = new Dictionary<string, string>();

            while (command != "Lumpawaroo")
            {
                List<string> current = new List<string>();
                string forceSide = string.Empty;
                string forceUser = string.Empty;

                if (command.Contains("|"))
                {
                    current = command.Split("|".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToList();
                    forceSide = current[0].Trim();
                    forceUser = current[1].Trim();

                    if (!forces.ContainsKey(forceSide))
                    {
                        forces.Add(forceSide, new List<string>());
                    }

                    if (!users.ContainsKey(forceUser)) //!
                    {
                        forces[forceSide].Add(forceUser); // new entry
                        users.Add(forceUser, forceSide);
                    }
                }
                else if (command.Contains("->"))
                {
                    current = command.Split("->".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToList();
                    forceUser = current[0].Trim();
                    forceSide = current[1].Trim();

                    Console.WriteLine($"{forceUser} joins the {forceSide} side!");

                    if (!users.ContainsKey(forceUser))
                    {
                        if (forces.ContainsKey(forceSide))
                        {
                            forces[forceSide].Add(forceUser); // new entry
                            users.Add(forceUser, forceSide);
                        }
                        else
                        {
                            forces.Add(forceSide, new List<string>());
                            forces[forceSide].Add(forceUser); // new entry

                            //[forceSide].Add(forceUser); // new entry
                            users.Add(forceUser, forceSide);
                        }                        
                    }
                    else
                    {
                        if (forces.ContainsKey(forceSide))
                        {
                            forces[forceSide].Add(forceUser); // move
                            string oldSide = users[forceUser];
                            forces[oldSide].Remove(forceUser);
                            users[forceUser] = forceSide;
                        }
                        else
                        {
                            forces.Add(forceSide, new List<string>());
                            forces[forceSide].Add(forceUser); // move
                            string oldSide = users[forceUser];
                            forces[oldSide].Remove(forceUser);
                            users[forceUser] = forceSide;
                        }
                       
                    }
                }

                command = Console.ReadLine();
            }

            forces = forces.OrderByDescending(x => x.Value.Count()).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

            foreach (var sideUser in forces)
            {
                if (sideUser.Value.Count > 0)
                {
                    Console.WriteLine($"Side: {sideUser.Key}, Members: {sideUser.Value.Count()}");

                    foreach (var user in sideUser.Value.OrderBy(x => x))
                    {
                        Console.WriteLine($"! {user}");
                    }
                }
            }
        }
    }
}
