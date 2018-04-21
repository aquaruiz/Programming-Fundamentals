using System;
using System.Linq;

namespace JumpAround
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int stepForwardBackward = input[0];
            int indexToStepFrom = 0;
            int sum = input[0];

            while (true)
            {
                if (indexToStepFrom + stepForwardBackward < input.Length)
                {
                    int prevStepIndex = stepForwardBackward;
                    sum += input[indexToStepFrom + stepForwardBackward];
                    stepForwardBackward = input[indexToStepFrom + stepForwardBackward];
                    indexToStepFrom = indexToStepFrom + prevStepIndex;
                }
                else if (indexToStepFrom + stepForwardBackward >= input.Length && indexToStepFrom - stepForwardBackward >= 0)
                {
                    int prevStepIndex = stepForwardBackward;
                    sum += input[indexToStepFrom - stepForwardBackward];
                    stepForwardBackward = input[indexToStepFrom - stepForwardBackward];
                    indexToStepFrom = indexToStepFrom - prevStepIndex;
                }
                else
                {
                    Console.WriteLine(sum);
                    return;
                }
            }
        }
    }
}
