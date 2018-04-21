using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiningCoins_Broken
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string decrypted = "";
            float totalValue = 0;

            for (int i = 1; i <= n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                int digit1 = number / 100;
                int digit2 = (number % 100) / 10;
                int digit3 = number % 10;

                int asciiCode = 0;

                if (i % 2 == 0)
                {
                    asciiCode = (digit1 * 10) + digit3 + digit2;
                }
                else
                {
                    asciiCode = int.Parse(digit1.ToString() + digit3.ToString()) - digit2;
                }

                if ((asciiCode >= 65 && asciiCode <= 90) || (asciiCode >= 97 && asciiCode <= 122))
                {
                    decrypted += (char)asciiCode;
                }

                totalValue += (digit1 + digit2 + digit3) / (float)n;
            }
            
            Console.WriteLine("Message: {0}", decrypted);
            Console.WriteLine("Value: {0:F7}", totalValue);
        }
    }
}
