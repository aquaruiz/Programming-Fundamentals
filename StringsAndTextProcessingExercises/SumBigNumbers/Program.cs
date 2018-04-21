using System;
using System.Text;
using System.Linq;

namespace SumBigNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstNumber = Console.ReadLine().TrimStart('0'); 
            string secondNumber = Console.ReadLine().TrimStart('0'); 

            if (firstNumber.Length < secondNumber.Length)
            {
                firstNumber = firstNumber.PadLeft(secondNumber.Length, '0');
            }
            else
            {
                secondNumber = secondNumber.PadLeft(firstNumber.Length, '0');
            }

            int reminder = 0;

            StringBuilder sb = new StringBuilder();

            for (int i = firstNumber.Length - 1; i >= 0; i--)
            {
                int nextDigitFromFirstNumber = int.Parse(firstNumber[i].ToString());
                int nextDigitFromSecondNumber = int.Parse(secondNumber[i].ToString());
                int sum = nextDigitFromFirstNumber + nextDigitFromSecondNumber + reminder;

                if (sum > 9)
                {
                    reminder = 1;
                    sum -= 10;
                }
                else
                {
                    reminder = 0;
                }

                sb.Insert(0, sum);
            }

            if (reminder == 1)
            {
                sb.Insert(0, reminder);
            }

            char[] output = sb.ToString().ToArray();

            Console.WriteLine(string.Join("", output));
        }
    }
}
