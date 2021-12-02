using System;

namespace deck_of_cards
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Player Bumi = new Player("Bumi");
            Bumi.Draw(2);

            Deck newdeck = new Deck();

            Bumi.Discard(1);

            
            // Card topCard = newdeck.Deal();

            // newdeck.Reset();

            // newdeck.Shuffle();
            

    



            
        }
    }
}
