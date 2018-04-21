using System;

namespace BPMCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            int beatsPerMinute = int.Parse(Console.ReadLine());
            int totalBeats = int.Parse(Console.ReadLine());

            double bars = Math.Round(totalBeats / 4.0, 1);
            double length = totalBeats / (double)beatsPerMinute;
            int minutes = (int)length;
            int seconds = (int)((length % 1) * 60);

            Console.WriteLine($"{bars} bars - {minutes}m {seconds}s");
        }
    }
}
