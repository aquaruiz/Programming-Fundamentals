using System;

namespace Debit_Card_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstNumber = int.Parse(Console.ReadLine());
            var secondNumber = int.Parse(Console.ReadLine());
            var thirdNumber = int.Parse(Console.ReadLine());
            var forthNumber = int.Parse(Console.ReadLine());

            Console.WriteLine($"{firstNumber:d4} {secondNumber:d4} {thirdNumber:d4} {forthNumber:d4}");
        }
    }
}
