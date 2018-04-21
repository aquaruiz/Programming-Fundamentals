using System;
using System.Linq;

namespace CountNegativeElementsInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split().ToArray();
            
            Console.WriteLine(arr.Count(s => s.ToCharArray().Length == 1 && s.ToCharArray()[0] >= 'A' && s.ToCharArray()[0] <= 'Z'));
        }
    }
}
