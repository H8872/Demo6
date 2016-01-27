using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    class Deck
    {
        public Stack<Card> deck = new Stack<Card>();

        public void AddCard(string maa, int numero)
        {
            Card card = new Card();
            card.Land = maa;
            card.Number = numero;
            deck.Push(card);
        }

    }
}
