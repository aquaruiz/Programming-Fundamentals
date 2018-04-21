using System;

namespace BoatSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstBootName = char.Parse(Console.ReadLine());
            char secondBootName = char.Parse(Console.ReadLine());
            int lines = int.Parse(Console.ReadLine());
            int firstBootMoves = 0;
            int secondBootMoves = 0;

            for (int i = 1; i <= lines; i++)
            {
                string moves = Console.ReadLine();                

                if (moves == "UPGRADE")
                {
                    firstBootName = (char)(firstBootName + 3);
                    secondBootName = (char)(secondBootName + 3);
                    
                }
                else
                {
                    if (i % 2 == 1)
                    {
                        firstBootMoves += moves.Length;
                    }
                    else
                    {
                        secondBootMoves += moves.Length;
                    }
                }

                if (firstBootMoves >= 50 || secondBootMoves >= 50)
                {
                    i = lines;
                    break;
                }
            }

            if (firstBootMoves > secondBootMoves)
            {
                Console.WriteLine(firstBootName);
            }
            else
            {
                Console.WriteLine(secondBootName);
            }
        }
    }
}
