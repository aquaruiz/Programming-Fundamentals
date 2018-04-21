using System;

namespace PhotoGallery
{
    class Program
    {
        static void Main(string[] args)
        {
            int fotoNumber = int.Parse(Console.ReadLine());
            int date = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int fotoSizeBytes = int.Parse(Console.ReadLine());
            int fotoWidth = int.Parse(Console.ReadLine());
            int fotoHeight = int.Parse(Console.ReadLine());

            string fotoName = $"DSC_{fotoNumber:0000}.jpg";
            string dateTime = $"{date:00}/{month:00}/{year:0000} {hours:00}:{minutes:00}";

            string fotoSize = "";

            if (fotoSizeBytes < 1000)
            {
                fotoSize = fotoSizeBytes + "B";
            }
            else if(fotoSizeBytes < 1000000)
            {
                fotoSize = fotoSizeBytes / 1000.0 + "KB";
            }
            else if (fotoSizeBytes < 1000000000)
            {
                fotoSize = fotoSizeBytes / 1000000.0 + "MB";
            }

            string resolution = $"{fotoWidth}x{fotoHeight}";

            string orientation = "";

            if (fotoWidth > fotoHeight)
            {
                orientation = "landscape";
            }
            else if(fotoWidth < fotoHeight)
            {
                orientation = "portrait";
            }
            else
            {
                orientation = "square";
            }

            Console.WriteLine($"Name: {fotoName}\nDate Taken: {dateTime}\nSize: {fotoSize}\nResolution: {resolution} ({orientation})");
        }
    }
}
