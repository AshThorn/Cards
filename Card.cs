//////////////////////////////////////////////////////////////////////////////
/// Project:        Cards
/// File Name:      Card.cs
/// Description:    playing card
/// Course:         CSCI 1260
/// Author:         Ash North
/// Created:        2022-10-08
/// Copyright:      Ash North, 2022
//////////////////////////////////////////////////////////////////////////////
namespace Cards
{
    /// <summary>
    /// a playing card
    /// </summary>
    public class Card
    {
        private Face face;
        private Suit suit;

        /// <summary>
        /// default constructor
        /// </summary>
        public Card()
        {
            this.face = Face.Queen;
            this.suit = Suit.Hearts;
        }

        /// <summary>
        /// normal parameterized constructor
        /// </summary>
        /// <param name="face">the face</param>
        /// <param name="suit">the suit</param>
        public Card(Face face, Suit suit)
        {
            this.face = face;
            this.suit = suit;
        }

        /// <summary>
        /// copy constructor
        /// </summary>
        /// <param name="card">card to be copied</param>
        public Card(Card card)
        {
            this.suit = card.suit;
            this.face = card.face;
        }

        /// <summary>
        /// weird paramaterized constructor
        /// </summary>
        /// <param name="i">integer from which a card is derived</param>
        public Card(int i)
        {
            face = (Face)Enum.GetValues(typeof(Face)).GetValue(i % 13);
            suit = (Suit)Enum.GetValues(typeof(Face)).GetValue(i % 4);
        }

        /// <summary>
        /// tostring
        /// </summary>
        /// <returns>description of the card</returns>
        public override string ToString()
        {
            return "the " + face + " of " + suit;
        }
    }
}