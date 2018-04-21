using System;
using System.Linq;

namespace DebugSequenceOfCommands
{
    class Program
    {
        private const char ArgumentsDelimiter = ' ';

        public static void Main()
        {
            int sizeOfArray = int.Parse(Console.ReadLine());

            long[] array = Console.ReadLine()
                .Split(ArgumentsDelimiter)
                .Select(long.Parse)
                .ToArray();

            var command = Console.ReadLine().Trim().Split(ArgumentsDelimiter).ToList();

            while (!command[0].ToLower().Equals("stop"))
            {
                var action = command[0].ToLower();
                int[] args = new int[2];

                if (action.Equals("add") ||
                    action.Equals("subtract") ||
                    action.Equals("multiply"))
                {
                    args[0] = int.Parse(command[1]);
                    args[1] = int.Parse(command[2]);

                    PerformAction(array, action, args);
                }
                else
                {
                    PerformAction(array, action, args);
                }

                Console.WriteLine();

                command = Console.ReadLine().Trim().Split(ArgumentsDelimiter).ToList();
            }
        }

        static void PerformAction(long[] arr, string action, int[] args)
        {
            long[] array = arr;
            int pos = args[0] - 1;
            int value = args[1];

            switch (action)
            {
                case "multiply":
                    array[pos] *= value;
                    break;
                case "add":
                    array[pos] += value;
                    break;
                case "subtract":
                    array[pos] -= value;
                    break;
                case "lshift":
                    ArrayShiftLeft(array);
                    break;
                case "rshift":
                    ArrayShiftRight(array);
                    break;
            }

            PrintArray(array);
        }

        private static void ArrayShiftRight(long[] array)
        {
            long oldLast = array[array.Length - 1];

            for (int i = array.Length - 1; i > 0; i--)
            {
                array[i] = array[i - 1];
            }

            array[0] = oldLast;
        }

        private static void ArrayShiftLeft(long[] array)
        {
            long oldFirst = array[0];

            for (int i = 0; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];                
            }
            array[array.Length - 1] = oldFirst;
        }

        private static void PrintArray(long[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}
