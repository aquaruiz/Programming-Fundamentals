using System;

namespace CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            string firstInput = input[0];
            string secondInput = input[1];

            if (firstInput.Length < secondInput.Length)
            {
                firstInput = firstInput.PadRight(secondInput.Length);
            }
            else
            {
                secondInput = secondInput.PadRight(firstInput.Length);
            }

            long sum = 0;

            for (int i = 0; i < firstInput.Length; i++)
            {
                if (firstInput[i] == ' ')
                {
                    sum += (int)secondInput[i];
                }
                else if (secondInput[i] == ' ')
                {
                    sum += (int)firstInput[i];
                }
                else
                {
                    sum += (int)firstInput[i] * (int)secondInput[i];
                }
            }

            Console.WriteLine(sum);
        }
    }
}
