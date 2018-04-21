using System;

namespace TheaThePhotographer
{
    class Program
    {
        static void Main(string[] args)
        {
            var takenPictures = int.Parse(Console.ReadLine());
            var onePictureFilteringInSeconds = int.Parse(Console.ReadLine());
            var percentGoodToUploadPictures = int.Parse(Console.ReadLine());
            var uploadTimePerPictureInSeconds = int.Parse(Console.ReadLine());

            var timeForFilteringInSeconds = takenPictures * onePictureFilteringInSeconds;
            var picturesToUpload = Math.Ceiling(percentGoodToUploadPictures / 100.0 * takenPictures);
            var uploadTimeTotalInSeconds = (long)(uploadTimePerPictureInSeconds * picturesToUpload);

            var totalTimeInSeconds = (long)(timeForFilteringInSeconds + uploadTimeTotalInSeconds);

            var days = (long)(totalTimeInSeconds / (24 * 60 * 60));
            var hours = (long)(totalTimeInSeconds / 60 / 60) - days * 24;
            var minutes = (long)(totalTimeInSeconds / 60 - hours * 60 - days * 24 * 60);
            var seconds = (long)totalTimeInSeconds % 60;

            Console.WriteLine($"{days}:{hours:00}:{minutes:00}:{seconds:00}");
        }
    }
}
