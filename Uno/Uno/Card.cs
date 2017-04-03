using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uno
{
    class Card
    {
        public enum CardColor
        {
            Red, Blue, Green, Yellow, Black
        }

        public enum CardValue
        {
            Zero, One, Two, Three, Four, Five, Six, Seven, Eight, Nine, Block, PlusTwo, PlusFour, Recolor, Reverse
        }

        CardColor Color;
        CardValue Value;

        public Card(CardColor color , CardValue value)
        {
            Color = color;
            Value = value;
        }



    }
}
