using System;

namespace IntegerToBase
{
    class Program
    {
        static void Main(string[] args)
        {
            long numberIn10 = int.Parse(Console.ReadLine());
            int toBase = int.Parse(Console.ReadLine());

            IntegerToBase(numberIn10, toBase);
        }

        static void IntegerToBase(long numberIn10, int toBase)
        {
            string newNumber = "";

            while (numberIn10 > 0)
            {
                long reminder = numberIn10 % toBase;
                newNumber = reminder + newNumber;
                numberIn10 /= toBase;
            }


            //string newNumber = Convert.ToString(numberIn10, toBase);
            Console.WriteLine(newNumber);
        }
    }
}
