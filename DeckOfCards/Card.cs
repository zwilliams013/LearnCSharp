using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCards
{
    //public enum Face { ACE, TWO, THREE, FOUR, FIVE, SIX, SEVEN, EIGHT, NINE, TEN, JACK, QUEEN, KING };
    //enum Suit { CLUB, DIAMOND, SPADE, HEART };

    class Card
    {
        public Face face;
        public Suit suit;

        public Card(Face face, Suit suit)
        {
            this.face = face;
            this.suit = suit;
        }

        public string toString()
        {
            return this.face + " of " + this.suit;
        }
    }
}
