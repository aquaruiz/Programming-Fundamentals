using System;

namespace Megapixels
{
    class Program
    {
        static void Main(string[] args)
        {
            int imageWidth = int.Parse(Console.ReadLine());
            int imageHeight = int.Parse(Console.ReadLine());

            double megapixels = Math.Round((double)(imageHeight * imageWidth) / 1000000.0, 1);

            Console.WriteLine($"{imageWidth}x{imageHeight} => {megapixels}MP");
        }
    }
}
