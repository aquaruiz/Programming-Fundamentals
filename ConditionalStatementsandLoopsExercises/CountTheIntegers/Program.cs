using System;

namespace CountTheIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            while (true)
            {
                try
                {
                    int number = int.Parse(Console.ReadLine());
                    counter++;
                }
                catch
                {
                    Console.WriteLine(counter);
                    return;
                }
            }
        }
    }
}
