using System;

namespace NumbersToWords
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int numberToLetterize = int.Parse(Console.ReadLine());
                Console.WriteLine(Letterize(numberToLetterize));
            }
        }

        static string Letterize(int number)
        {
            string nameOfNumber = "";

            if (number > 999)
            {
                return "too large";
            }
            else if (number < -999)
            {
                return "too small";
            }
            else if (number < 100 && number > -100)
            {
                return "";
            }
            else
            {
                if (number < 0)
                {
                    nameOfNumber += "minus ";
                    number = Math.Abs(number);
                }

                int firstDigit = number / 100;
                nameOfNumber += NameOfDigit(firstDigit) + "-hundred";

                if (number.ToString()[1] == '0' && number.ToString()[2] == '0')
                {
                    return nameOfNumber;                    
                }

                nameOfNumber += " and ";

                int secondDigit = (number - 100 * firstDigit) / 10;
                if (secondDigit != 0)
                {
                    nameOfNumber += NameOfDigit(secondDigit) + "ty ";
                }

                int thirdDigit = number % 10;
                nameOfNumber += NameOfDigit(thirdDigit);                
            }

            if (nameOfNumber.Contains("onety"))
            {
                nameOfNumber = nameOfNumber.Replace("onety", "ten");
            }

            if (nameOfNumber.Contains("twoty"))
            {
                nameOfNumber = nameOfNumber.Replace("twoty", "twenty");
            }

            if (nameOfNumber.Contains("threety"))
            {
                nameOfNumber = nameOfNumber.Replace("threety", "thirty");
            }

            if (nameOfNumber.Contains("fivety"))
            {
                nameOfNumber = nameOfNumber.Replace("fivety", "fifty");
            }

            if (nameOfNumber.Contains("ten") && number % 10 == 1)
            {
                nameOfNumber = nameOfNumber.Replace("ten one", "eleven");
            }
            if (nameOfNumber.Contains("ten") && number % 10 == 2)
            {
                nameOfNumber = nameOfNumber.Replace("ten two", "twelve");
            }
            if (nameOfNumber.Contains("ten") && number % 10 == 3)
            {
                nameOfNumber = nameOfNumber.Replace("ten three", "thirteen");
            }
            if (nameOfNumber.Contains("ten") && number % 10 == 4)
            {
                nameOfNumber = nameOfNumber.Replace("ten four", "fourteen");
            }
            if (nameOfNumber.Contains("ten") && number % 10 == 5)
            {
                nameOfNumber = nameOfNumber.Replace("ten five", "fifteen");
            }
            if (nameOfNumber.Contains("ten") && number % 10 == 6)
            {
                nameOfNumber = nameOfNumber.Replace("ten six", "sixteen");
            }
            if (nameOfNumber.Contains("ten") && number % 10 == 7)
            {
                nameOfNumber = nameOfNumber.Replace("ten seven", "seventeen");
            }
            if (nameOfNumber.Contains("ten") && number % 10 == 8)
            {
                nameOfNumber = nameOfNumber.Replace("ten eight", "eighteen");
            }
            if (nameOfNumber.Contains("ten") && number % 10 == 9)
            {
                nameOfNumber = nameOfNumber.Replace("ten nine", "nineteen");
            }


            return nameOfNumber;
        }

        static string NameOfDigit(int digit)
        {
            switch (digit)
            {
                case 0: return "";
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";
                default: return "error";
            }

            
        }
    }
}
