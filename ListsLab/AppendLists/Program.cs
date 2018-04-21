using System;
using System.Collections.Generic;
using System.Linq;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<List<string>> collections = Console.ReadLine().Split('|').Select(s => s.Split(' ').ToList()).ToList();

            foreach (var collection in collections)
            {
                for (int i = 0; i < collection.Count; i++)
                {
                    if (collection[i] == "")
                    {
                        collection.RemoveAt(i);
                    }
                }
            }

            foreach (var collection in collections)
            {
                collection.Select(int.Parse);
            }

            collections.Reverse();

            foreach (var list in collections)
            {
                Console.Write(string.Join(" ", list) + " ");
            }
        }
    }
}
