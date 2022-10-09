//////////////////////////////////////////////////////////////////////////////
/// Project:        Cards
/// File Name:      Deck.cs
/// Description:    a deck of playing cards (without jokers)
/// Course:         CSCI 1260
/// Author:         Ash North
/// Created:        2022-10-08
/// Copyright:      Ash North, 2022
//////////////////////////////////////////////////////////////////////////////
namespace Cards
{
    /// <summary>
    /// collection of 52 playing cards
    /// </summary>
    public class Deck
    {
        private Card[] deckCards;
        private int nextCard;

        /// <summary>
        /// default constructor
        /// </summary>
        public Deck()
        {
            deckCards = new Card[52];
            int deckIndex = 0;
            foreach (Face face in Enum.GetValues<Face>())
            {
                foreach(Suit suit in Enum.GetValues<Suit>())
                {
                    deckCards[deckIndex] = new Card(face, suit);
                    deckIndex++;
                }
            }
            nextCard = 0;
        }

        /// <summary>
        /// copy constructor
        /// </summary>
        /// <param name="deck">deck to be copied</param>
        public Deck(Deck deck)
        {
            this.deckCards = deck.deckCards;
            this.nextCard = deck.nextCard;//I'm assuming we want an identical copy and not a fresh deck
        }

        /// <summary>
        /// shuffles the deck
        /// </summary>
        public void Shuffle()
        {
            Random random = new Random();
            Card temp;
            int swap;
            for(int i = 0; i < deckCards.Length; i++)
            {
                temp = new Card(deckCards[i]);
                swap=random.Next(52);
                deckCards[i]=new Card(deckCards[swap]);
                deckCards[swap]=temp;

            }
        }

        /// <summary>
        /// draw a card from the deck
        /// </summary>
        /// <returns>the card drawn</returns>
        public Card DealACard()
        {
            return deckCards[nextCard++];
        }

        /// <summary>
        /// deals a hands of cards
        /// </summary>
        /// <param name="handSize">cards to deal</param>
        /// <returns>string describing the cards</returns>
        public string DealAHand(int handSize)
        {
            int startingIndex = nextCard;
            string hand = "";
            for(; nextCard<handSize+startingIndex-1; nextCard++)
            {
                hand += deckCards[nextCard]+", ";
            }
            hand += deckCards[nextCard++];
            return hand;
        }

        /// <summary>
        /// all the cards in order in the deck
        /// </summary>
        /// <returns>a string of the cards</returns>
        public override string ToString()
        {
            string output = "";
            foreach(Card card in deckCards)
            {
                output += card + "\n";
            }
            return output.Substring(0, output.Length - 2);
        }
    }
}
