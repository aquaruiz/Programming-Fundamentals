using System;

namespace Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int countOfStarts = n % 2 == 0 ? 2 : 1;
            int countOfDashes = (n - 1) / 2;
            string dashes = new string('-', countOfDashes);
            string stars = new string('*', countOfStarts);

            if (n < 3)
            {
                Console.WriteLine($"{stars}");
            }
            else
            {
                Console.WriteLine("{0}{1}{0}", dashes, stars);

                int middleDashes = countOfStarts;

                for (int row = 0; row < (n - 1) / 2; row++)
                {
                    countOfDashes--;
                    string middle = new string('-', middleDashes);
                    dashes = new string('-', countOfDashes);

                    Console.WriteLine("{0}*{1}*{0}", dashes, middle);
                    middleDashes += 2;
                }

                middleDashes -= 4;

                for (int row = 0; row < (n - 1) / 2 - 1; row++)
                {
                    countOfDashes++;
                    string middle = new string('-', middleDashes);
                    dashes = new string('-', countOfDashes);

                    Console.WriteLine("{0}*{1}*{0}", dashes, middle);
                    middleDashes -= 2;
                }

                countOfDashes++;
                dashes = new string('-', countOfDashes);
                Console.WriteLine("{0}{1}{0}", dashes, stars);
            }
        }
    }
}

