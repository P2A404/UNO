using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uno
{
    class UnoGame
    {
        public UnoGame(int playersNum)
        {
            players = new Player[playersNum];
            for (int i = 0; i < players.Length; i++)
            {
                players[i] = new Player(deck);
            }
        }
        Player[] players;
        Deck deck = new Deck();
    }
}
