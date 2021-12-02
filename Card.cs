using System;
using System.Collections.Generic;

namespace deck_of_cards
{
    public class Card
    {
        public string cardVal;
        public string Suit;
        public int numVal;


        public Card(string faceVal, string suitVal, int val)
        {
            cardVal = faceVal;
            Suit = suitVal;
            numVal = val;
        }
    }
}