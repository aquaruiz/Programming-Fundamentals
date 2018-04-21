using System;
using System.Collections.Generic;
using System.Linq;

namespace BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] bombProperties = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int bombName = bombProperties[0];
            int bompPower = bombProperties[1];

            while (input.Contains(bombName))
            {
                int bombPosition = - 1;

                for (int i = 0; i < input.Count; i++)
                {
                    if (input[i] == bombName)
                    {
                        bombPosition = i;
                        break;
                    }
                }
                int newBombPositon = bombPosition;

                if (bombPosition - bompPower < 0)
                {
                    for (int i = 0; i < bombPosition; i++)
                    {
                        input.RemoveAt(0);
                        newBombPositon--;
                    }
                }
                else
                {
                    for (int i = bombPosition - bompPower; i < bombPosition; i++)
                    {
                        input.RemoveAt(bombPosition - bompPower);
                        newBombPositon--;
                    }

                }
                
                bombPosition = newBombPositon;

                if (bombPosition + bompPower > input.Count - 1)
                {
                    for (int i = bombPosition + 1; i < input.Count; i++)
                    {
                        input.RemoveAt(bombPosition + 1);
                    }
                }
                else
                {
                    for (int i = bombPosition + 1; i <= bombPosition + bompPower; i++)
                    {
                        input.RemoveAt(bombPosition + 1);
                    }
                }
                
                input.RemoveAt(bombPosition);
            }

            Console.WriteLine(input.Sum());
        }
    }
}
