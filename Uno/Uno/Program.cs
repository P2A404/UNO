using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uno
{
    class Program
    {
        static void Main(string[] args)
        {
            UnoGame game = new UnoGame(1);
            game.PrintGame();

            Console.Read();
        }
    }
}
