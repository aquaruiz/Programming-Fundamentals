using System;
using System.Linq;

namespace Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] phoneNumbers = Console.ReadLine().Split().ToArray();
            string[] names = Console.ReadLine().Split().ToArray();

            string input = Console.ReadLine();
            int foundOnIndex = -1;
            bool isCallingAName = true;

            while (input != "done")
            {
                string[] callingNumber = input.Split().ToArray();
                string action = callingNumber[0];
                string nameOrNumber = callingNumber[1];

                try
                {
                    int checkIsNumber = int.Parse(nameOrNumber[nameOrNumber.Length - 1].ToString());
                    isCallingAName = false;

                    for (int i = 0; i < phoneNumbers.Length; i++)
                    {
                        if (nameOrNumber == phoneNumbers[i])
                        {
                            foundOnIndex = i;
                            break;
                        }
                    }
                }
                catch 
                {
                    isCallingAName = true;
                    for (int i = 0; i < names.Length; i++)
                    {
                        if (nameOrNumber == names[i])
                        {
                            foundOnIndex = i;
                            break;
                        }
                    }
                }

                string callNumber = phoneNumbers[foundOnIndex];
                string phoneNumberToTransform = callNumber;

                while (phoneNumberToTransform.Contains("+") 
                    || phoneNumberToTransform.Contains("-")
                    || phoneNumberToTransform.Contains("(")
                    || phoneNumberToTransform.Contains(")"))
                {
                    phoneNumberToTransform = phoneNumberToTransform.Replace("+", string.Empty);
                    phoneNumberToTransform = phoneNumberToTransform.Replace("-", string.Empty);
                    phoneNumberToTransform = phoneNumberToTransform.Replace("(", string.Empty);
                    phoneNumberToTransform = phoneNumberToTransform.Replace(")", string.Empty);
                }                

                long intCallNumber = long.Parse(phoneNumberToTransform);                

                if (action == "call")
                {
                    Console.WriteLine("calling {0}...", (isCallingAName ? phoneNumbers[foundOnIndex] : names[foundOnIndex]));

                    int sumOfDigits = intCallNumber.ToString().ToCharArray().ToList().Select(s => int.Parse(s.ToString())).Sum();

                    if (sumOfDigits % 2 == 1)
                    {
                        Console.WriteLine("no answer");
                    }
                    else
                    {
                        int durationInSecs = sumOfDigits;
                        int sec = durationInSecs % 60;
                        int min = durationInSecs / 60;
                        Console.WriteLine("call ended. duration: {0:d2}:{1:d2}", min, sec);
                    }
                }
                else if (action == "message")
                {
                    Console.WriteLine("sending sms to {0}...", (isCallingAName ? phoneNumbers[foundOnIndex] : names[foundOnIndex]));

                    int differenceInDigits = 0;

                    for (int i = 0; i < phoneNumberToTransform.Length; i++)
                    {
                        differenceInDigits -= int.Parse(phoneNumberToTransform[i].ToString());
                    }

                    if (Math.Abs(differenceInDigits) % 2 == 1)
                    {
                        Console.WriteLine("busy");
                    }
                    else
                    {
                        Console.WriteLine("meet me there");
                    }
                }

                input = Console.ReadLine();
            }
        }
    }
}
