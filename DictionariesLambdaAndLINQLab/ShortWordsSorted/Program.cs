using System;
using System.Linq;

namespace ShortWordsSorted
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().ToLower().Split(".,:;()[]\"\'\\/!? ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            string[] output = input.Distinct().Where(y => y.Length < 5).OrderBy(x => x).ToArray();

            Console.WriteLine(string.Join(", ", output));
        }
    }
}
