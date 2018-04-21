using System;

namespace Wormtest
{
    class Program
    {
        static void Main(string[] args)
        {
            long wormLengthInMeters = long.Parse(Console.ReadLine());
            decimal wormWidthInCentimeters = decimal.Parse(Console.ReadLine());
            decimal wormLenghtInCentimeters = wormLengthInMeters * 100;

            if (wormLenghtInCentimeters == 0 || wormWidthInCentimeters == 0)
            {
                Console.WriteLine($"{wormLenghtInCentimeters * wormWidthInCentimeters:f2}");
                return;
            }

            decimal devisionProduct = wormLenghtInCentimeters % wormWidthInCentimeters;

            if (devisionProduct == 0)
            {
                Console.WriteLine($"{wormLenghtInCentimeters * wormWidthInCentimeters:f2}");
            }
            else
            {
                Console.WriteLine($"{wormLenghtInCentimeters / wormWidthInCentimeters * 100:f2}%");
            }
        }
    }
}
