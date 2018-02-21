using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCards
{
   
    class DeckofCards
    {
        private Card[] deck = new Card[52];
        public DeckofCards()
        {            
            for (int i = 0; i < deck.Length; i++)
            {
                deck[i] = new Card((Face)(i%13), (Suit)(i/13));
            }
        }

        public void printDeck()
        {
            for (int i = 0; i < deck.Length; i++)
            {
                Console.WriteLine(deck[i].toString());
            }
        }

        public void shuffle()
        {
            Card temp = deck[0];
            Random rand = new Random();
            int randNum;
            for (int i = 0; i < deck.Length; i++)
            {
                randNum = rand.Next(deck.Length);
                temp = deck[i];
                deck[i] = deck[randNum];
                deck[randNum] = temp;
            }
        }

        public void sortDeck()
        {
            //Use of bubble sort
            for (int i = 0; i < deck.Length; i++)
            {
                for (int j = 0; j < deck.Length-1; j++)
                {
                    if(deck[j].face > deck[j+1].face)
                    {
                        Card temp = deck[j];
                        deck[j] = deck[j + 1];
                        deck[j + 1] = temp;
                    }
                    if (deck[j].suit > deck[j + 1].suit)
                    {
                        Card temp = deck[j];
                        deck[j] = deck[j + 1];
                        deck[j + 1] = temp;
                    }
                }
            }
        }
    }
}
