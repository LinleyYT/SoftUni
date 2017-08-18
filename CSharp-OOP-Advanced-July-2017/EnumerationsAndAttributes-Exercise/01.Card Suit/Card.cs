using System;

namespace _01.Card_Suit
{
    public class Card : IComparable<Card>
    {
        public Card(CardRank rank, CardSuit suit)
        {
            this.Rank = rank;
            this.Suit = suit;
        }

        public CardRank Rank { get; private set; }
        public CardSuit Suit { get; private set; }

        public int Power()
        {
            return (int) this.Rank + (int) this.Suit;
        }

        public override string ToString()
        {
            return $"{this.Rank} of {this.Suit}";
        }

        public int CompareTo(Card other)
        {
            if (ReferenceEquals(this, other)) return 0;
            if (ReferenceEquals(null, other)) return 1;
            var rankComparison = this.Power().CompareTo(other.Power());
            return rankComparison;
        }
    }
}