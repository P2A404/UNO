using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uno
{
    class Player
    {
        public Player(Deck deck, string name)
        {
            for (int i = 0; i < 7; i++)
            {
                hand.Draw(deck);
            }
            Name = name;
        }
        public string  Name;
        public Hand hand = new Hand();
    }
}
