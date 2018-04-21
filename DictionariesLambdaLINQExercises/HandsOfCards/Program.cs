using System;
using System.Collections.Generic;
using System.Linq;

namespace HandsOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, List<string>> drawCardsByPerson = new Dictionary<string, List<string>>();

            while (input != "JOKER")
            {
                string[] draw = input.Split(':').ToArray();
                string player = draw[0];
                List<string> drawnCards = draw[1].Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToList();

                if (!drawCardsByPerson.ContainsKey(player))
                {
                    drawCardsByPerson.Add(player, drawnCards);
                }
                else
                {
                    drawCardsByPerson[player].AddRange(drawnCards);
                }
                
                input = Console.ReadLine();
            }

            int playerCardsSum = 0;

            foreach (var playerAndCards in drawCardsByPerson)
            {
                foreach (var card in playerAndCards.Value.Distinct())
                {
                    char cardColor = card[card.Length - 1];
                    string cardValue = card.Remove(card.Length - 1, 1);
                    int colorPoints = 0;
                    int valuePoints = 0;

                    switch (cardColor)
                    {
                        case 'S': colorPoints = 4;
                            break;
                        case 'H': colorPoints = 3;
                            break;
                        case 'D': colorPoints = 2;
                            break;
                        case 'C': colorPoints = 1;
                            break;
                    }

                    switch (cardValue)
                    {
                        case "2": valuePoints = 2;
                            break;
                        case "3": valuePoints = 3;
                            break;
                        case "4": valuePoints = 4;
                            break;
                        case "5": valuePoints = 5;
                            break;
                        case "6": valuePoints = 6;
                            break;
                        case "7": valuePoints = 7;
                            break;
                        case "8": valuePoints = 8;
                            break;
                        case "9": valuePoints = 9;
                            break;
                        case "10": valuePoints = 10;
                            break;
                        case "J": valuePoints = 11;
                            break;
                        case "Q": valuePoints = 12;
                            break;
                        case "K": valuePoints = 13;
                            break;
                        case "A": valuePoints = 14;
                            break;
                    }

                    playerCardsSum += colorPoints * valuePoints;
                }

                Console.WriteLine($"{playerAndCards.Key}: {playerCardsSum}");
                playerCardsSum = 0;
            }
        }
    }
}
