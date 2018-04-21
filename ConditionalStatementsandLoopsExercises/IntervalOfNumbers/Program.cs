using System;

namespace IntervalOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOne = int.Parse(Console.ReadLine());
            var numberTwo = int.Parse(Console.ReadLine());

            if (!(numberOne < numberTwo))
            {
                numberTwo += numberOne;
                numberOne = numberTwo - numberOne;
                numberTwo -= numberOne;
            }

            for (int i = numberOne; i <= numberTwo; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
