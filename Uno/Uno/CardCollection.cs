using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uno
{
    abstract class CardCollection
    {
        public List<Card> cards = new List<Card>();
    }

    class Deck : CardCollection
    {
        public Deck()
        {
            //add jokers and joker+4
            for (int i = 0; i < 4; i++)
            {
                cards.Add(new Card(Card.CardColor.Black, Card.CardValue.Recolor));
                cards.Add(new Card(Card.CardColor.Black, Card.CardValue.PlusFour));
            }
            //add 2 of each non-joker non-zero cards of each non-black color and 1 zero card of each non-black color
            foreach (Card.CardColor CC in Enum.GetValues(typeof(Card.CardColor)))
            {
                foreach (Card.CardValue CV in Enum.GetValues(typeof(Card.CardValue)))
                {
                    if (CC != Card.CardColor.Black || CV != Card.CardValue.PlusFour || CV != Card.CardValue.Recolor)
                    {
                        if (CV == Card.CardValue.Zero)
                        {
                            cards.Add(new Card(CC, CV));
                        }
                        else
                        {
                            cards.Add(new Card(CC, CV));
                            cards.Add(new Card(CC, CV));
                        }
                    }
                }
            }
        }
    }

    class Hand : CardCollection
    {

    }

    class Pile : CardCollection
    {

    }
}
