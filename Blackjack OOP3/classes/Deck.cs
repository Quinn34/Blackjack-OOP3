using Blackjack_OOP3.classes;
using System;
using System.Collections.Generic;

namespace Blackjack_OOP3.classes
{
    internal class Deck
    {
        private List<Card> cards;
        private static Random rng = new Random();

        public Deck()
        {
            
            cards = new List<Card>();
            InitializeDeck();
        }

        private void InitializeDeck()
        {
            foreach (Suits suit in Enum.GetValues(typeof(Suits)))
            {
                foreach (FaceValues faceValue in Enum.GetValues(typeof(FaceValues)))
                {
                    cards.Add(new Card(suit, faceValue));
                }
            }
        }

        public void ShuffleCards()
        {
            Shuffle();
        }

        public Card DealCard()
        {
            if (cards.Count == 0)
            {
                Console.WriteLine("No cards left");

            }

            Card dealtCard = cards[0];
            cards.RemoveAt(0);
            return dealtCard;
        }

        public void Shuffle()
        {
            for (int cardCount = cards.Count - 1; cardCount > 0; cardCount--)
            {
                int R = rng.Next(cardCount + 1);
                (cards[cardCount], cards[R]) = (cards[R], cards[cardCount]);
            }
        }

        public int CardsRemaining()
        {
            return cards.Count;
        }
    }
}