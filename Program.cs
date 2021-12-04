using System;

namespace deck_of_cards
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck newdeck = new Deck();
            newdeck.Shuffle();
            Player Bumi = new Player("Bumi");
            Bumi.Draw(newdeck, 5);

            

            Bumi.Discard(1);

            
            // Card topCard = newdeck.Deal();

            // newdeck.Reset();

            // newdeck.Shuffle();
            

    



            
        }
    }
}
