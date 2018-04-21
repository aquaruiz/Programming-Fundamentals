using System;
using System.Collections.Generic;
using System.Linq;

namespace KarateStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> input = Console.ReadLine().ToList();
            char punch = '>';
            int strength = 0;
            int length = 0;
            List<char> output = new List<char>();

            while (input.Contains(punch))
            {
                int indexOfPunch = input.IndexOf(punch);
                strength = int.Parse(input[indexOfPunch + 1].ToString());

                if (length == 0)
                {
                    length = strength;
                }
                else
                {
                    strength += length;
                    length = strength;
                }

                for (int i = 0; i <= indexOfPunch; i++)
                {
                    output.Add(input[i]);
                }

                for (int i = 0; i <= indexOfPunch; i++)
                {
                    input.RemoveAt(0);
                }

                if (strength > input.Count)
                {
                    strength = input.Count;
                }
                for (int i = 0; i < strength; i++)
                {
                    if (input[0] != punch)
                    {
                        input.RemoveAt(0);
                        length--;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            if (input.Count > 0)
            {
                for (int i = 0; i < input.Count; i++)
                {
                    output.Add(input[i]);
                }
            }            

            Console.WriteLine(string.Join("", output));
        }
    }
}
