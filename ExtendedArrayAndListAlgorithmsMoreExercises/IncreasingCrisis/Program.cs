using System;
using System.Collections.Generic;
using System.Linq;

namespace IncreasingCrisis
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<int> output = new List<int>();
            bool isSequenceCorrect = true;
            bool foundPlace = false;

            for (int i = 0; i < n; i++)
            {
                List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();

                for (int j = 1; j < input.Count; j++)
                {
                    if (input[j] >= input[j - 1])
                    {
                        continue;
                    }
                    else
                    {
                        input.RemoveRange(j, input.Count - j);
                        isSequenceCorrect = false;
                        break;
                    }
                }

                if (output.Count > 0)
                {
                    for (int k = output.Count - 1; k >= 0; k--)
                    {
                        if (output[k] <= input[0])
                        {
                            foundPlace = true;
                            if (!isSequenceCorrect)
                            {
                                output.RemoveRange(k + 1, (output.Count - (k + 1)));
                                output.AddRange(input);
                            }
                            else
                            {
                                //for (int l = input.Count - 1; l >= 0; l--)
                                //{
                                //    if (input[l] > output[k + 1])
                                //    {
                                //        input.RemoveAt(l);
                                //        output.RemoveRange(k + 1, output.Count - (k + 1));
                                //        break;
                                //    }
                                //}

                                output.InsertRange((k + 1), input);
                            }

                            break;
                        }

                    }

                    if (!foundPlace)
                    {
                        output.InsertRange(0, input);
                    }
                }
                else
                {
                    output.AddRange(input);
                }
            }

            Console.WriteLine(string.Join(" ", output));
        }
    }
}
