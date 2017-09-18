using System;
using System.Linq;

namespace _01.Card_Suit
{
    public class StartUp
    {
        public static void Main()
        {
            var nameA = Console.ReadLine();
            var nameB = Console.ReadLine();
            var playerA = new Deck(nameA);
            var playerB = new Deck(nameB);

            while (playerA.DeckOfCards.Count != 5)
            {
                var cardInput = Console.ReadLine().Split();
                var rank = cardInput[0];
                var suit = cardInput[2];

                var rankEnum = CardRank.Blank;
                var suitEnum = CardSuit.Undefined;

                try
                {
                    if (Enum.TryParse(rank, out rankEnum) && Enum.TryParse(suit, out suitEnum))
                    {
                        var currentCard = new Card(rankEnum, suitEnum);

                        if (playerA.DeckOfCards.Any(x => x.Power() == currentCard.Power())
                            || playerB.DeckOfCards.Any(x => x.Power() == currentCard.Power()))
                        {
                            throw new ArgumentException("Card is not in the deck.");
                        }

                        playerA.AddCard(currentCard);
                    }
                    else
                    {
                        throw new ArgumentException("No such card exists.");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            while (playerB.DeckOfCards.Count != 5)
            {
                var cardInput = Console.ReadLine().Split();
                var rank = cardInput[0];
                var suit = cardInput[2];

                var rankEnum = CardRank.Blank;
                var suitEnum = CardSuit.Undefined;

                try
                {
                    if (Enum.TryParse(rank, out rankEnum) && Enum.TryParse(suit, out suitEnum))
                    {
                        var currentCard = new Card(rankEnum, suitEnum);

                        if (playerA.DeckOfCards.Any(x => x.Power() == currentCard.Power())
                            || playerB.DeckOfCards.Any(x => x.Power() == currentCard.Power()))
                        {
                            throw new ArgumentException("Card is not in the deck.");
                        }

                        playerB.AddCard(currentCard);
                    }
                    else
                    {
                        throw new ArgumentException("No such card exists.");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            if (playerA.DeckOfCards.Max(x => x.Power()) > playerB.DeckOfCards.Max(x => x.Power()))
            {
                Console.WriteLine(
                    $"{playerA.Name} wins with {playerA.DeckOfCards.OrderByDescending(x => x.Power()).FirstOrDefault()}.");
            }
            else
            {
                Console.WriteLine(
                    $"{playerB.Name} wins with {playerB.DeckOfCards.OrderByDescending(x => x.Power()).FirstOrDefault()}.");
            }
        }
    }
}