using System;
using System.Linq;
using System.Text;

namespace _01.Card_Suit
{
    public class StartUp
    {
        public static void Main()
        {
            var deck = new Deck();
            var cardRank = Console.ReadLine();
            var cardSuit = Console.ReadLine();
            var cardRank2 = Console.ReadLine();
            var cardSuit2 = Console.ReadLine();
            var rank = (CardRank) Enum.Parse(typeof(CardRank), cardRank);
            var suit = (CardSuit) Enum.Parse(typeof(CardSuit), cardSuit);
            var rank2 = (CardRank)Enum.Parse(typeof(CardRank), cardRank2);
            var suit2 = (CardSuit)Enum.Parse(typeof(CardSuit), cardSuit2);
            var cardOne = new Card(rank, suit);
            var cardTwo = new Card(rank2, suit2);

            if (cardOne.CompareTo(cardTwo) > 0)
            {
                Console.WriteLine(cardOne); 
            }
            else
            {
                Console.WriteLine(cardTwo);
            }
        }
    }
}
