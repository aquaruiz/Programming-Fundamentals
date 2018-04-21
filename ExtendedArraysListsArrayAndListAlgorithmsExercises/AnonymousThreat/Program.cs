using System;
using System.Collections.Generic;
using System.Linq;

namespace AnonymousThreat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split().ToList();

            string command = Console.ReadLine();

            while (command != "3:1")
            {
                string action = command.Split()[0];

                if (action == "merge")
                {
                    int startIndex = int.Parse(command.Split()[1]);
                    int endIndex = int.Parse(command.Split()[2]);

                    if (startIndex < 0 || startIndex > input.Count - 1)
                    {
                        startIndex = 0;
                    }

                    if (endIndex > input.Count - 1)
                    {
                        endIndex = input.Count - 1;
                    }

                    string newMember = string.Empty;

                    for (int i = startIndex; i <= endIndex; i++)
                    {
                        newMember += input[i];
                    }

                    input.Insert(startIndex, newMember);
                    input.RemoveRange(startIndex + 1, endIndex - startIndex + 1);                    
                }
                else if (action == "divide")
                {
                    int index = int.Parse(command.Split()[1]);
                    int partitions = int.Parse(command.Split()[2]);

                    if (partitions == 0)
                    {
                        input.RemoveAt(index);
                        break;
                    }
                    List<string> newMembersList = new List<string>();
                    int subStringLenght = input[index].Count() / partitions;

                    for (int i = 0; i < input[index].Count(); i += subStringLenght)
                    {
                        string newMember = input[index].Substring(i, subStringLenght);
                        newMembersList.Add(newMember);
                    }

                    if (input[index].Count() % partitions != 0)
                    {
                        // members to delete = input[index].Count % partitions + 1;
                        int indexToStartDel = newMembersList.Count - 1 - input[index].Count() % partitions;
                        int rangeToDel = input[index].Count() % partitions + 1;
                        newMembersList.RemoveRange(indexToStartDel, rangeToDel);

                        int lengthLastMember = input[index].Count() - newMembersList.Count;
                        
                        newMembersList.Add(input[index].Substring(input[index].Count() - lengthLastMember, lengthLastMember));
                    }

                    input.RemoveAt(index);

                    if (index > input.Count - 1)
                    {
                        input.AddRange(newMembersList);
                    }
                    else
                    {
                        input.InsertRange(index, newMembersList);
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", input));
        }
    }
}
