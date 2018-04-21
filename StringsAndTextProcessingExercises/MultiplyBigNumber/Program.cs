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
            long secondNumber = long.Parse(Console.ReadLine());

            if (firstNumber == "0" || secondNumber == 0 || firstNumber == string.Empty)
            {
                Console.WriteLine(0);
                return;
            }

            long reminder = 0;

            StringBuilder sb = new StringBuilder();

            for (int i = firstNumber.Length - 1; i >= 0; i--)
            {
                int nextDigitFromFirstNumber = int.Parse(firstNumber[i].ToString());
                long sum = nextDigitFromFirstNumber * secondNumber + reminder;
                reminder = 0;

                if (sum > 9)
                {
                    reminder = sum / 10;
                    sum = sum % 10;
                }

                sb.Insert(0, sum);
            }

            if (reminder > 0)
            {
                sb.Insert(0, reminder);
            }

            char[] output = sb.ToString().ToArray();

            Console.WriteLine(string.Join("", output));
        }
    }
}
