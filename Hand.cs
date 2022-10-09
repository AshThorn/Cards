//////////////////////////////////////////////////////////////////////////////
/// Project:        Cards
/// File Name:      Hand.cs
/// Description:    a hand of playing cards
/// Course:         CSCI 1260
/// Author:         Ash North
/// Created:        2022-10-08
/// Copyright:      Ash North, 2022
//////////////////////////////////////////////////////////////////////////////
namespace Cards
{
    /// <summary>
    /// a collection of playing cards to be held by a player
    /// </summary>
    public class Hand
    {
        private readonly static int defaultHandSize = 5;
        private Card[] gameHand;
        private int handSize;
        private int cardsInHand;

        /// <summary>
        /// default constructor
        /// </summary>
        public Hand()
        {
            handSize = defaultHandSize;
            cardsInHand = 0;
            gameHand = new Card[handSize];
        }

        /// <summary>
        /// paramaeterized constructor
        /// </summary>
        /// <param name="handSize">max cards in hand</param>
        public Hand(int handSize)
        {
            this.handSize = handSize;
            cardsInHand = 0;
            gameHand = new Card[handSize];
        }

        /// <summary>
        /// copy constructor
        /// </summary>
        /// <param name="existingHand">hand to be copied</param>
        public Hand(Hand existingHand)
        {
            handSize = existingHand.handSize;
            cardsInHand = existingHand.cardsInHand;
            gameHand = new Card[handSize];
            copyHand(existingHand.gameHand);
        }

        /// <summary>
        /// copies an array of cards
        /// </summary>
        /// <param name="toCopy">the array to copy</param>
        private void copyHand(Card[] toCopy)
        {
            for(int i = 0; i < gameHand.Length; i++)
            {
                gameHand[i] = toCopy[i];
            }
        }

        /// <summary>
        /// put a card in the hand
        /// </summary>
        /// <param name="card">card to be added</param>
        public void AddACard(Card card)
        {
            try
            {
                if (cardsInHand < handSize)
                {
                    gameHand[cardsInHand++] = card;
                }
                else
                {
                    throw new IndexOutOfRangeException("Index out of range.");
                }
            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// tostring
        /// </summary>
        /// <returns>the cards in the hand as a string</returns>
        public override string ToString()
        {
            string outStr = "";
            foreach (Card card in gameHand)
            {
                outStr += card + "\n";
            }
            return outStr.Substring(0, outStr.Length-2);
        }

        public int GetHandSize()
        {
            return handSize;
        }
    }
}
