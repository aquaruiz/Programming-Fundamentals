using System;

namespace GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputType = Console.ReadLine();
            switch (inputType)
            {
                case "int":
                    int int1 = int.Parse(Console.ReadLine());
                    int int2 = int.Parse(Console.ReadLine());
                    int maxInt = GetMax(int1, int2);
                    Console.WriteLine(maxInt);
                    break;
                case "char":
                    char char1 = char.Parse(Console.ReadLine());
                    char char2 = char.Parse(Console.ReadLine());
                    char maxChar = GetMax(char1, char2);
                    Console.WriteLine(maxChar);
                    break;
                case "string":
                    string string1 = Console.ReadLine();
                    string string2 = Console.ReadLine();
                    string maxString = GetMax(string1, string2);
                    Console.WriteLine(maxString);
                    break;
            }
        }

        static string GetMax(string string1, string string2)
        {
            if (string1.CompareTo(string2) >= 0)
            {
                return string1;
            }
            else
            {
                return string2;
            }
        }

        static int GetMax(int int1, int int2)
        {
            return Math.Max(int1, int2);
        }

        static char GetMax(char char1, char char2)
        {
            if (char1 >= char2)
            {
                return char1;
            }
            else
            {
                return char2;
            }
        }
    }
}
