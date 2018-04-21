using System;
using System.Collections.Generic;
using System.Linq;

namespace OnlyLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> input = Console.ReadLine().ToCharArray().ToList();

            for (int i = 0; i < input.Count; i++)
            {
                try
                {
                    if (int.Parse(input[i].ToString()) >= 0 && int.Parse(input[i].ToString()) <= 9)
                    {
                        bool isThereALeterAfterwards = false;

                        for (int j = i; j < input.Count; j++)
                        {
                            if ((input[j] >= 'a' && input[j] <= 'z') || (input[j] >= 'A' && input[j] <= 'Z'))
                            {
                                isThereALeterAfterwards = true;
                                break;
                            }
                        }

                        if (isThereALeterAfterwards)
                        {
                            input.RemoveAt(i);
                            i--;
                        }                        

                        if ((input[i + 1] >= 'a' && input[i + 1] <= 'z') || (input[i + 1] >= 'A' && input[i + 1] <= 'Z'))
                        {
                            input.Insert((i + 1), input[i + 1]);
                        }
                    }
                }
                catch {}
                
            }

            Console.WriteLine(string.Join("", input));
        }
    }
}
