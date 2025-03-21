using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack_OOP3.classes
{
    public enum Suits
    {
        CLUBS,
        DIAMONDS,
        HEARTS,
        SPADES
    }

    public enum FaceValues
    {
        ACE = 1,
        TWO,
        THREE,
        FOUR,
        FIVE,
        SIX,
        SEVEN,
        EIGHT,
        NINE,
        TEN,
        JACK,
        QUEEN,
        KING
    }
    public class Card
    {
        Suits suit;
        FaceValues faceValue;
        int value;
        Image img;

        public Suits Suit
        {
            get
            {
                return suit;
            }
        }

        public int Value
        {
            get { return value; }
            set
            {
                if (faceValue == FaceValues.ACE)
                {
                    this.value = value;
                }
            }
        }

        public Card(Suits suit, FaceValues faceValue)
        {
            this.suit = suit;
            this.faceValue = faceValue;
            switch (faceValue)
            {
                case FaceValues.ACE:
                    this.value = 11;
                    break;
                case FaceValues.TEN:
                case FaceValues.JACK:
                case FaceValues.QUEEN:
                case FaceValues.KING:
                    this.value = 10;
                    break;
                default:
                    this.value = (int)faceValue;
                    break;
            }
        }

        public override string ToString()
        {
            return this.faceValue + " Of " + this.suit;
        }
        public string CardOutput()
        {
            return $"{faceValue} of {Suit}";
        }
    }
}
