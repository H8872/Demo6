using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    class Deck
    {
        public List<Card> deck = new List<Card>();
        Card card = new Card();

        public void AddCard(string maa, int numero)
        {
            card.Land = maa;
            card.Number = numero;
            deck.Add(card);
        }

    }
}
