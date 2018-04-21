using System;

namespace HouseBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstNumber = Console.ReadLine();
            sbyte smallNumber = 0;
            int biggerNumber = 0;
            try
            {
                smallNumber = sbyte.Parse(firstNumber);
            }
            catch 
            {
                biggerNumber = int.Parse(firstNumber);
            }

            string secondNumber = Console.ReadLine();

            try
            {
                smallNumber = sbyte.Parse(secondNumber);
            }
            catch
            {
                biggerNumber = int.Parse(secondNumber);
            }

            long price = (long)smallNumber * 4 + (long)biggerNumber * 10;
            Console.WriteLine(price);
        }
    }
}
