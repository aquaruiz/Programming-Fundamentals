using System;

namespace MelrahShake
{
    class Program
    {
        static void Main(string[] args)
        {
            string characters = Console.ReadLine();
            string pattern = Console.ReadLine();

            while (characters.Length > 0 && pattern.Length > 0)
            {
                int firstIndex = characters.IndexOf(pattern);
                int lastIndex = characters.LastIndexOf(pattern);

                if (firstIndex >= 0 && lastIndex >= 0 && firstIndex != lastIndex)
                {
                    Console.WriteLine("Shaked it.");

                    characters = characters.Remove(firstIndex, pattern.Length);
                    lastIndex = characters.LastIndexOf(pattern);
                    characters = characters.Remove(lastIndex, pattern.Length);

                    pattern = pattern.Remove(pattern.Length / 2, 1);
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine("No shake.");
            Console.WriteLine(characters);
        }
    }
}
