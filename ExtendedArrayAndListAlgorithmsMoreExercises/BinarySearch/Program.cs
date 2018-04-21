using System;
using System.Linq;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] input = Console.ReadLine().Split().Select(double.Parse).ToArray();
            double intToSearchFor = double.Parse(Console.ReadLine());
            int linearCounter = 0;
            bool isFoundLinear = false;

            // linear search
            for (int i = 0; i < input.Length; i++)
            {
                linearCounter++;
                if (intToSearchFor == input[i])
                {
                    isFoundLinear = true;
                    break;
                }
            }

            // binary search
            input = input.OrderBy(x => x).ToArray();

            int binaryCounter = 0;
            int startIndex = 0;
            int endIndex = input.Length - 1;
            bool isFoundBinary = false;

            while (!isFoundBinary)
            {
                if (endIndex < startIndex)
                {
                    break;
                }

                binaryCounter++;
                int middleOfTheInput = startIndex + (endIndex - startIndex) / 2;

                if (input[middleOfTheInput] < intToSearchFor)
                {
                    startIndex = middleOfTheInput + 1;
                }
                else if (input[middleOfTheInput] > intToSearchFor)
                {
                    endIndex = middleOfTheInput - 1;
                }
                else if(input[middleOfTheInput] == intToSearchFor)
                {
                    isFoundBinary = true;
                }                
            }

            if (isFoundLinear || isFoundBinary)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

            Console.WriteLine("Linear search made {0} iterations", linearCounter);
            Console.WriteLine("Binary search made {0} iterations", binaryCounter);
        }
    }
}
