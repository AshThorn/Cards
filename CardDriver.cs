using System;

namespace Cards
{
    public class CardDriver
    {
        public static void Main(string[] args)
        {
            Card defaultCard = new Card();
            Console.WriteLine("The default card is " + defaultCard);

            int i = 0;
            Card generatedCard = new Card();
            do
            {
                Console.WriteLine("Enter an integer to create a card. If you wish to stop, enter -1.");
                i = int.Parse(Console.ReadLine());
                if (i == -1)
                    continue;
                generatedCard = new Card(i);
                Console.WriteLine("You made " + generatedCard);
            }
            while (i != -1);

            Console.WriteLine("All 52 cards follow:");
            Console.WriteLine(new Deck());
            //is this cheap? I don't know. I mean, I did the work necessary to make this work, but not in the intended fashion?

            Console.WriteLine("Thank you for using this program. Closing.");
        }
    }
}
