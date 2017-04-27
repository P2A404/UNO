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

        public override string ToString()
        {
            string print = "";
            switch (Color)
            {
                case CardColor.Red:
                    print = "Red ";
                    break;
                case CardColor.Blue:
                    print = "Blue ";
                    break;
                case CardColor.Green:
                    print = "Green ";
                    break;
                case CardColor.Yellow:
                    print = "Yellow ";
                    break;

            }
            switch (Value)
            {
                case CardValue.Zero:
                    print += "Zero";
                    break;
                case CardValue.One:
                    print += "One";
                    break;
                case CardValue.Two:
                    print += "Two";
                    break;
                case CardValue.Three:
                    print += "Three";
                    break;
                case CardValue.Four:
                    print += "Four";
                    break;
                case CardValue.Five:
                    print += "Five";
                    break;
                case CardValue.Six:
                    print += "Six";
                    break;
                case CardValue.Seven:
                    print += "Seven";
                    break;
                case CardValue.Eight:
                    print += "Eight";
                    break;
                case CardValue.Nine:
                    print += "Nine";
                    break;
                case CardValue.Block:
                    print += "Block";
                    break;
                case CardValue.Reverse:
                    print += "Reverse";
                    break;
                case CardValue.PlusTwo:
                    print += "+2";
                    break;
                case CardValue.PlusFour:
                    print += "+4";
                    break;
                case CardValue.Recolor:
                    print += "Change Color";
                    break;
            }
            return print;
        }




    }
}
