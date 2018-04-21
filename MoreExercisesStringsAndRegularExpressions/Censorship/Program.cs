using System;
using System.Collections.Generic;
using System.Linq;

namespace Censorship
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string[] sentance = Console.ReadLine().Split();

            for (int i = 0; i < sentance.Length; i++)
            {
                if (sentance[i] == word)
                {
                    sentance[i] = new string('*', word.Length);
                }
                else if (sentance[i].Contains(word))
                {
                    int index = sentance[i].IndexOf(word);
                    List<char> current = sentance[i].ToCharArray().ToList();

                    for (int j = 0; j < word.Length; j++)
                    {
                        current.RemoveAt(index);
                    }

                    for (int j = 0; j < word.Length; j++)
                    {
                        current.Insert(index, '*');
                    }

                    sentance[i] = string.Join("", current);
                }
            }

            Console.WriteLine(string.Join(" ", sentance));
        }
    }
}
