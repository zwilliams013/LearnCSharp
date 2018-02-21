using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCards
{
    enum Face { ACE, TWO, THREE, FOUR, FIVE, SIX, SEVEN, EIGHT, NINE, TEN, JACK, QUEEN, KING };
    enum Suit { CLUBS, DIAMONDS, SPADES, HEARTS };

    //public enum Face { A, TO, TH, FO, FI, SI, SE, ET, N, T, J, Q, K };
    //public enum Suit { C, D, S, H };

    class Program
    {
        static void Main(string[] args)
        {
            //Card c1 = new Card(Face.JACK, Suit.CLUBS);
            //Console.WriteLine((int)c1.face);

            DeckofCards deck = new DeckofCards();
            //deck.printDeck();
            deck.shuffle();

           
            deck.printDeck();
            Console.WriteLine();

            deck.sortDeck();
            deck.printDeck();

            Console.ReadKey();
        }

    }
}
