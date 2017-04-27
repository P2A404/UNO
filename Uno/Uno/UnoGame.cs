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
                players[i] = new Player(deck,"test");
            }
            currPlayer = players[0];
            
        }

        Player currPlayer;
        Player[] players;
        Deck deck = new Deck();

        public void PrintGame()
        {
            Console.WriteLine(currPlayer.Name);
            Console.WriteLine(currPlayer.hand); 
        }
    }
}
