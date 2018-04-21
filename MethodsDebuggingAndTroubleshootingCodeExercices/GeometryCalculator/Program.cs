using System;

namespace GeometryCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string figureType = Console.ReadLine().ToLower();

            double area = 0;
            switch(figureType)
            {
                case "triangle":
                    double side = double.Parse(Console.ReadLine());
                    double height = double.Parse(Console.ReadLine());
                    area = CalcAreaTriangle(side, height);
                    break;
                case "square":
                    side = double.Parse(Console.ReadLine());
                    area = CalcAreaSquareReactangle(side, side);
                    break;
                case "rectangle":
                    double width = double.Parse(Console.ReadLine());
                    height = double.Parse(Console.ReadLine());
                    area = CalcAreaSquareReactangle(width, height);
                    break;
                case "circle":
                    double radius = double.Parse(Console.ReadLine());
                    area = CalcAreaCircle(radius);
                    break;
            }

            Console.WriteLine($"{area:f2}");
        }

        static double CalcAreaCircle(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        static double CalcAreaTriangle(double side, double height)
        {
            return (side * height) / 2.0;
        }

        static double CalcAreaSquareReactangle(double width, double height)
        {
            return width * height;
        }
    }
}
