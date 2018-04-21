using System;

namespace ComparingFloats
{
    class Program
    {
        private static bool isClose;

        static void Main(string[] args)
        {
            var num1 = double.Parse(Console.ReadLine());
            var num2 = double.Parse(Console.ReadLine());

            var eps = 0.000001;

            bool isClose = true;

            if (Math.Abs(num1 - num2) > eps)
            {
                isClose = false;
            }

            Console.WriteLine(isClose);
        }
    }
}
