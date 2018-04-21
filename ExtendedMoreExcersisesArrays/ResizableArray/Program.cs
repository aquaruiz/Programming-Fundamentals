using System;
using System.Linq;

namespace ResizableArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            long?[] arr = new long?[4];
            int counter = 0;

            while (command != "end")
            {
                string[] actionsElements = command.Split().ToArray();
                string action = actionsElements[0];
                
                if (action == "push")
                {
                    long element = long.Parse(actionsElements[1]);
                    counter++;

                    for (int i = 0; i < arr.Length; i++)
                    {
                        if (arr[i] == null)
                        {
                            arr[i] = element;
                            break;
                        }
                    }
                }
                else if (action == "pop")
                {
                    for (int i = 0; i < arr.Length; i++)
                    {
                        if (arr[i] == null)
                        {
                            arr[i - 1] = null;
                            break;
                        }
                    }
                }
                else if (action == "removeAt")
                {
                    int index = int.Parse(actionsElements[1]);
                    arr[index] = null;

                    for (int j = index; j < arr.Length - 1; j++)
                    {
                        arr[j] = arr[j + 1];
                        arr[j + 1] = null;
                    }

                    counter--;
                }
                else if (action == "clear")
                {
                    for (int i = 0; i < arr.Length; i++)
                    {
                        arr[i] = null;
                    }
                }

                if (counter > arr.Length - 1)
                {
                    long?[] newArr = new long?[arr.Length * 2];
                    Array.Copy(arr, newArr, arr.Length);
                    counter = newArr.Length;
                    arr = new long?[newArr.Length];
                    Array.Copy(newArr, arr, counter);
                }

                command = Console.ReadLine();
            }

            bool isThereANum = false;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != null)
                {
                    isThereANum = true;
                    break;
                }
            }

            if (isThereANum)
            {
                Console.WriteLine(string.Join(" ", arr));
            }
            else
            {
                Console.WriteLine("empty array");
            }
        }
    }
}
