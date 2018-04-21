using System;

namespace MaxMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int biggerNum = GetMax(num1, num2);
            int biggestNum = GetMax(biggerNum, num3);

            Console.WriteLine(biggestNum);
        }

        static int GetMax(int one, int two)
        {
            int maxNum = Math.Max(one, two);
            return maxNum;
        }
    }
}
