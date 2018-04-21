using System;

namespace CenterPodouble
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            string closerToCenter = CalcCloserToCenterLine(x1, y1, x2, y2, x3, y3, x4, y4);
            Console.WriteLine(closerToCenter);
        }

        static string CalcCloserToCenterLine(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            var lineLength1 = PythagorasRule((x1 - x2), (y1 - y2));
            var lineLength2 = PythagorasRule((x3 - x4), (y3 - y4));

            if (lineLength1 >= lineLength2)
            {                
                return CalcCloserToCenterPodoubleOrder(x1, y1, x2, y2);
            }
            else
            {
                return CalcCloserToCenterPodoubleOrder(x3, y3, x4, y4);
            }            
        }

        static string CalcCloserToCenterPodoubleOrder(double x1, double y1, double x2, double y2)
        {
            var distanceToCenterPodouble1 = PythagorasRule(x1, y1);
            var distanceToCenterPodouble2 = PythagorasRule(x2, y2);

            if (distanceToCenterPodouble1 <= distanceToCenterPodouble2)
            {
                return $"({x1}, {y1})({x2}, {y2})";
            }
            else
            {
                return $"({x2}, {y2})({x1}, {y1})";

            }
        }

        static double PythagorasRule(double x1, double y1)
        {
            return Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2));
        }
    }
}
