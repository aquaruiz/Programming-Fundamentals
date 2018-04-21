using System;
using System.Collections.Generic;
using System.Linq;

namespace Extremums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] integers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string command = Console.ReadLine();
            List<int> maxList = new List<int>();
            List<int> minList = new List<int>();
            int maxSum = 0;
            int minSum = 0;

            if (command == "Min")
            {
                foreach (var integer in integers)
                {
                    int newMember = MakeIntSmallest(integer);
                    minList.Add(newMember);
                    minSum += newMember;
                }

                Console.WriteLine(string.Join(", ", minList));
                Console.WriteLine(minSum);
            }
            else if (command == "Max")
            {
                foreach (var integer in integers)
                {
                    int newMember = MakeIntBiggest(integer);
                    maxList.Add(newMember);
                    maxSum += newMember;
                }

                Console.WriteLine(string.Join(", ", maxList));
                Console.WriteLine(maxSum);
            }

            
        }

        private static int MakeIntSmallest(int integer)
        {
            int newInteger1 = integer;
            int newInteger2 = integer;

            while (true)
            {
                string stringInteger = newInteger1.ToString();

                if (stringInteger.Length == 1)
                {
                    break;
                }

                int firstDigit = int.Parse(stringInteger[0].ToString());
                int secondDigit = int.Parse(stringInteger[1].ToString());

                if (firstDigit >= secondDigit)
                {
                    newInteger1 = MoveFirstDigitToEnd(newInteger1);
                }
                else
                {
                    break;
                }
            }

            while (true)
            {
                string stringInteger = newInteger2.ToString();

                if (stringInteger.Length == 1)
                {
                    break;
                }

                int firstDigit = int.Parse(stringInteger[0].ToString());
                int lastDigit = int.Parse(stringInteger[stringInteger.Length - 1].ToString());

                if (firstDigit >= lastDigit)
                {
                    newInteger2 = MoveLastDigitToStart(newInteger2);
                }
                else
                {
                    break;
                }
            }

            if (newInteger1 < newInteger2)
            {
                return newInteger1;
            }
            else
            {
                return newInteger2;
            }
        }

        private static int MoveLastDigitToStart(int integer)
        {
            List<char> charInteger = integer.ToString().ToCharArray().ToList();
            charInteger.Insert(0, charInteger[charInteger.Count - 1]);
            charInteger.RemoveAt(charInteger.Count - 1);

            return int.Parse(string.Join("", charInteger));
        }

        private static int MoveFirstDigitToEnd(int integer)
        {
            List<char> charInteger = integer.ToString().ToCharArray().ToList();
            charInteger.Add(charInteger[0]);
            charInteger.RemoveAt(0);

            return int.Parse(string.Join("", charInteger));
        }

        private static int MakeIntBiggest(int integer)
        {
            int newInteger1 = integer;
            int newInteger2 = integer;

            while (true)
            {
                string stringInteger = newInteger1.ToString();

                if (stringInteger.Length == 1)
                {
                    break;
                }


                int firstDigit = int.Parse(stringInteger[0].ToString());
                int secondDigit = int.Parse(stringInteger[1].ToString());

                if (firstDigit <= secondDigit)
                {
                    newInteger1 = MoveFirstDigitToEnd(newInteger1);
                }
                else
                {
                    break;
                }
            }

            while (true)
            {
                string stringInteger = newInteger2.ToString();

                if (stringInteger.Length == 1)
                {
                    break;
                }

                int firstDigit = int.Parse(stringInteger[0].ToString());
                int lastDigit = int.Parse(stringInteger[stringInteger.Length - 1].ToString());

                if (firstDigit <= lastDigit)
                {
                    newInteger2 = MoveLastDigitToStart(newInteger2);
                }
                else
                {
                    break;
                }
            }

            if (newInteger1 > newInteger2)
            {
                return newInteger1;
            }
            else
            {
                return newInteger2;
            }
        }  
    }
}
