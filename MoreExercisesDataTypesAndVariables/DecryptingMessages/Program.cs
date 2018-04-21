using System;

namespace DecryptingMessages
{
    class Program
    {
        static void Main(string[] args)
        {
            int keyNumber = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            string message = "";

            for (int i = 0; i < n; i++)
            {
                char character = char.Parse(Console.ReadLine());
                message += (char)(character + keyNumber);
            }

            Console.WriteLine(message);
        }
    }
}
