using System;
using System.Collections.Generic;
using System.Linq;

namespace JapaneseRoulette
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> gunCylinder = Console.ReadLine().Split().Select(int.Parse).ToList();
            string[] playersStrengths = Console.ReadLine().Split();

            int beginPosition = gunCylinder.FindIndex(num => num == 1);
            int endPosition = 0;

            for (int i = 0; i < playersStrengths.Length; i++)
            {
                string[] playerMoves = playersStrengths[i].Split(',');
                int spinPower = int.Parse(playerMoves[0]);
                string spinDirection = playerMoves[1];

                if (spinDirection == "Right")
                {
                    endPosition = beginPosition + spinPower % gunCylinder.Count;

                    if (endPosition >= gunCylinder.Count)
                    {
                        endPosition -= gunCylinder.Count;
                    }
                }
                else if (spinDirection == "Left")
                {
                    endPosition = beginPosition - spinPower % gunCylinder.Count;

                    if (endPosition < 0)
                    {
                        endPosition += gunCylinder.Count;
                    }
                }

                if (endPosition == 2)
                {
                    Console.WriteLine($"Game over! Player {i} is dead.");
                    return;
                }

                beginPosition = ++endPosition;
            }

            Console.WriteLine("Everybody got lucky!");
        }
    }
}
