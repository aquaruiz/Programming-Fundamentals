using System;
using System.Collections.Generic;
using System.Linq;

namespace Hideout
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> map = Console.ReadLine().ToCharArray().ToList();
            string[] clue = Console.ReadLine().Split();

            while (true)
            {
                char hideout = char.Parse(clue[0]);
                int minCoutCharsToSearch = int.Parse(clue[1]);

                if (!map.Contains(hideout))
                {
                    clue = Console.ReadLine().Split();
                    continue;
                }


                int index;
                int lengthOfClue;
                index = map.IndexOf(hideout);

                while (index < map.Count)
                {
                    lengthOfClue = 0;

                    for (int i = index; i < map.Count; i++)
                    {
                        if (map[i] == hideout)
                        {
                            lengthOfClue++;
                        }
                        else
                        {
                            if (lengthOfClue >= minCoutCharsToSearch)
                            {
                                Console.WriteLine("Hideout found at index {0} and it is with size {1}!", index, lengthOfClue);
                                return;
                            }

                            index = i + 1;
                            break;
                        }
                    }                    
                }

                clue = Console.ReadLine().Split();
            }
        }
    }
}
