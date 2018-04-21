using System;

namespace CalculateTriangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            double heigth = double.Parse(Console.ReadLine());
            double area = CalculateTriangleArea(side, heigth);

            Console.WriteLine(area);
        }

        static double CalculateTriangleArea(double side, double heigth)
        {
            return side * heigth / 2.0;
        }
    }
}
