using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uno
{
    abstract class CardCollection
    {
        List<Card> cards = new List<Card>();
    }

    class Deck : CardCollection
    {
        public Deck()
        {
            
        }
    }

    class Hand : CardCollection
    {
        
    }

    class Pile : CardCollection
    {
        
    }
}
