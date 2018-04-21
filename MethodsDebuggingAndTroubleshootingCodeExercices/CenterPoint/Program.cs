using System;

namespace CenterPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            string closerToCenter = CalcCloserToCenterPoint(x1, y1, x2, y2);
            Console.WriteLine(closerToCenter);
        }

        static string CalcCloserToCenterPoint(double x1, double y1, double x2, double y2)
        {
            var distanceToCenter1 = Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2));
            var distanceToCenter2 = Math.Sqrt(Math.Pow(x2, 2) + Math.Pow(y2, 2));

            if (distanceToCenter1 <= distanceToCenter2)
            {
                return $"({x1}, {y1})";
            }
            else
            {
                return $"({x2}, {y2})";

            }
        }
    }
}
