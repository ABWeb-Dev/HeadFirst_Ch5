using System;
using System.Collections.Generic;
using System.Text;

namespace PlayingCardEx
{
    class Card
    {
        public Suits Suit { get; set; }
        public Values Value { get; set; }
        public string Name { get { return $"{Value} of {Suit}"; } }

        public Card(Suits suit, Values value)
        {
            Suit = suit;
            Value =  value;
        }


    }
}
