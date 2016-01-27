using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck pakka = new Deck();
            int i, j;
            string Maa;
            for (i = 0; i <= 3; i++)
            {
                switch (i)
                {
                    case 0:
                        {
                            Maa = "Pata";
                            break;
                        }
                    case 1:
                        {
                            Maa = "Ruutu";
                            break;
                        }
                    case 2:
                        {
                            Maa = "Risti";
                            break;
                        }
                    case 3:
                        {
                            Maa = "Hertta";
                            break;
                        }
                    default:
                        {
                            Maa = "Jokeri";
                            break;
                        }
                }
                for (j = 1; j <= 13; j++)
                {
                    pakka.AddCard(Maa, j);
                }
            }

            foreach(Card card in pakka.deck)
            {
                Console.WriteLine(card.ToString);
            }
        }
    }
}
