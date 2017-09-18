using System.Collections;
using System.Collections.Generic;

namespace _01.Card_Suit
{
    public class Deck : IEnumerable<Card>
    {
        public Deck(string name)
        {
            this.DeckOfCards = new List<Card>();
            this.Name = name;
        }

        public string Name { get; private set; }
        public List<Card> DeckOfCards { get; private set; }

        public void AddCard(Card card)
        {
            this.DeckOfCards.Add(card);
        }

        public IEnumerator<Card> GetEnumerator()
        {
            for (int i = 0; i < this.DeckOfCards.Count; i++)
            {
                yield return this.DeckOfCards[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}