using System;
using System.Collections.Generic;

namespace deck_of_cards
{
    public class Deck
    {
    public string [] cardVal = new string[]
    {"Ace","2","3","4","5","6","7","8","9","10","Jack","Queen","King"};

    public string[] Suit = new string[]
    {"Clubs","Spades","Hearts","Diamonds"};

    List<Card> newDeck = new List<Card>();
    public Deck()
    {
        Reset();
    }

        public Card Deal()
        {
            Console.WriteLine("- - - - - - Dealing Card- - - - - -");
            Card dealt = newDeck[0];
            // Console.WriteLine($"player was dealt {dealt.cardVal} of {dealt.Suit}");
            newDeck.Remove(dealt);
            // foreach(Card card in newDeck)
            // {
            //     Console.WriteLine(card.cardVal + " of "+ card.Suit);
            // }
            return dealt;
        }

        public void Reset()
        {
            // Console.WriteLine("- - - - - - - - Deck Resetting- - - - - - -  -");
            newDeck.Clear();
        for(int i = 0; i<cardVal.Length; i++)
        {
            for( int j = 0; j < Suit.Length; j++)
            {
                Card newCard = new Card(cardVal[i], Suit[j], i+1);
                newDeck.Add(newCard);
            }
        }
        // foreach(Card card in newDeck)
        // {
        //     Console.WriteLine(card.cardVal + " of "+ card.Suit + " " + card.numVal);
        // }


        }

        public void Shuffle()
        {
            Console.WriteLine("- - - - - - - - Shuffling - - - - - - - ");
            Random rand = new Random ();
            int idx = 0;
            while (idx < newDeck.Count)
            {
                Card temp = newDeck[idx];
                Card newIdx = newDeck[rand.Next(0,newDeck.Count)];
                newDeck[idx] = newIdx;
                newIdx = temp;
                idx++;
            }
            // foreach(Card card in newDeck)
            // {
            //     Console.WriteLine(card.cardVal + " of "+ card.Suit);
            // }
        }


    }
}