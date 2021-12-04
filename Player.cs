using System;
using System.Collections.Generic;

namespace deck_of_cards
{
    public class Player
    {
        public string Name;
        public List<Card> Hand = new List<Card>();

        public Player (string name)
        {
            Name = name;
        }

        public Card Draw(Deck d, int num)
        {
            Console.WriteLine($"{Name} drew {num} cards from the deck.");
            Card card = null;
            for(int i = 1; i <= num; i++)
            {
                card = d.Deal();
                Hand.Add(card);
                Console.WriteLine($"{Name} drew the {card.cardVal} of {card.Suit} and added it to their hand.{card.numVal}");
            }
            return card;
        }

        public Card Discard(int idx)
        {
            if (idx > Hand.Count -1 )
            {
                return null;
            } 
            else
            {
                Card discardPile= Hand[idx];
                Hand.Remove(discardPile);
                Console.WriteLine($"Player discarded the {discardPile.cardVal} of {discardPile.Suit}");
                return discardPile;
            }
        }

    }


}