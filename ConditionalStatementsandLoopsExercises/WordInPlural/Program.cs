using System;

namespace WordInPlural
{
    class Program
    {
        static void Main(string[] args)
        {
            string singularNoun = Console.ReadLine();
            string pluralNoun = "";
            if (singularNoun.EndsWith('y'))
            {
                pluralNoun = singularNoun.Remove(singularNoun.Length - 1) + "ies";
            }
            else if(singularNoun.EndsWith('o') 
                || singularNoun.EndsWith('s')
                || singularNoun.EndsWith('x')
                || singularNoun.EndsWith('z')
                || singularNoun.EndsWith("ch")
                || singularNoun.EndsWith("sh"))
            {
                pluralNoun = singularNoun + "es";
            }
            else
            {
                pluralNoun = singularNoun + "s";
            }

            Console.WriteLine(pluralNoun);
        }
    }
}
