using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uno
{
    class Player
    {
        public Player(Deck deck)
        {
            for (int i = 0; i < 7; i++)
            {
                hand.Draw(deck);
            }
        }
        Hand hand = new Hand();
    }
}
