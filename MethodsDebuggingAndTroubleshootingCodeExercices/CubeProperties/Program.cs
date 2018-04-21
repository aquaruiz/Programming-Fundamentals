using System;

namespace CubeProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            string parameter = Console.ReadLine();
            double answer = 0;

            switch (parameter)
            {
                case "face": answer = CalcFaceDiagonal(side);
                    break;
                case "space": answer = CalcSpaceDiagonal(side);
                    break;
                case "volume": answer = CalcCubeVolume(side);
                    break;
                case "area": answer = CalcCubeArea(side);
                    break;                        
            }

            Console.WriteLine("{0:0.00}", answer);
        }

        static double CalcCubeArea(double side)
        {
            return 6 * Math.Pow(side, 2);
        }

        static double CalcCubeVolume(double side)
        {
            return Math.Pow(side, 3);
        }

        static double CalcSpaceDiagonal(double side)
        {
            return side * Math.Sqrt(3);
        }

        static double CalcFaceDiagonal(double side)
        {
            return side * Math.Sqrt(2);
        }
    }
}
