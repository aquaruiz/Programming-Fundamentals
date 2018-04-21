using System;

namespace PracticeFloatingPointNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            float flo = 0f;
            double dou = 0;
            decimal dec = 0m;

            string num1 = Console.ReadLine();
            string num2 = Console.ReadLine();
            string num3 = Console.ReadLine();

            if (num1.Length <= 8)
            {
                try
                {
                    flo = float.Parse(num1);
                    Console.WriteLine(flo);
                }
                catch
                {
                    dou = double.Parse(num1);
                    Console.WriteLine(dou);
                }                
            }
            else if (num1.Length <= 16)
            {
                try
                {
                    dou = double.Parse(num1);
                    Console.WriteLine(dou);
                }
                catch 
                {
                    dec = decimal.Parse(num1);
                    Console.WriteLine(dec);
                }
            }
            else
            {
                dec = decimal.Parse(num1);
                Console.WriteLine(dec);
            }

            if (num2.Length <= 8)
            {
                try
                {
                    flo = float.Parse(num2);
                    Console.WriteLine(flo);
                }
                catch
                {
                    dou = double.Parse(num2);
                    Console.WriteLine(dou);
                }
            }
            else if (num2.Length <= 16)
            {
                try
                {
                    dou = double.Parse(num2);
                    Console.WriteLine(dou);
                }
                catch
                {
                    dec = decimal.Parse(num2);
                    Console.WriteLine(dec);
                }
            }
            else
            {
                dec = decimal.Parse(num2);
                Console.WriteLine(dec);
            }

            if (num3.Length <= 8)
            {
                try
                {
                    flo = float.Parse(num3);
                    Console.WriteLine(flo);
                }
                catch
                {
                    dou = double.Parse(num3);
                    Console.WriteLine(dou);
                }
            }
            else if (num3.Length <= 16)
            {
                try
                {
                    dou = double.Parse(num3);
                    Console.WriteLine(dou);
                }
                catch
                {
                    dec = decimal.Parse(num3);
                    Console.WriteLine(dec);
                }
            }
            else
            {
                dec = decimal.Parse(num3);
                Console.WriteLine(dec);
            }
        }
    }
}
