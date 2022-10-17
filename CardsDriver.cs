//////////////////////////////////////////////////////////////////////////////
/// Project:        Cards
/// File Name:      CardsDriver.cs
/// Description:    demonstrates the use of the cards project
/// Course:         CSCI 1260
/// Author:         Ash North
/// Created:        2022-10-08
/// Copyright:      Ash North, 2022
//////////////////////////////////////////////////////////////////////////////
namespace Cards
{
    /// <summary>
    /// creates and shuffles a deck, makes a copy of that deck,
    /// then deals and displays two hands from the copied deck
    /// </summary>
    public class CardsDriver
    {
        private static Deck deck, deckCopy;
        private static Hand hand1, hand2;

        /// <summary>
        /// main method
        /// </summary>
        /// <param name="args">supplies params from the console when running the program</param>
        /*public static void Main(string[] args)
        {
            deck = new Deck();
            System.Console.WriteLine(deck + "\n");
            deck.Shuffle();
            System.Console.WriteLine(deck);

            deckCopy = new Deck(deck);
            
            hand1 = new Hand(7);
            for(int i = 0; i < hand1.GetHandSize(); i++)
            {
                hand1.AddACard(deckCopy.DealACard());
            }
            
            hand2 = new Hand(7);
            for (int i = 0; i < hand2.GetHandSize(); i++)
            {
                hand2.AddACard(deckCopy.DealACard());
            }

            System.Console.WriteLine("\n" + hand1);
            System.Console.WriteLine("\n" + hand2);
        }*/
    }
}
