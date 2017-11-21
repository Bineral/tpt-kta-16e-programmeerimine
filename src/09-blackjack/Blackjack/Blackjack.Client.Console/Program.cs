namespace Blackjack.Client.Console
{
    using System;

    using Blackjack.Core;

    public class Program
    {
        // All aces are 11 points. In real life, one can choose whether it is 1 or 11
        // When user draws a card, house always draws one as-well. In real life, house can decide based on some rules...  

        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the game of Blackjack!");
            Console.WriteLine();

            var c4 = new Card("4", 'C', 4);
            c4.Hidden = false;

            var h6 = new Card("6", 'H', 6);
            h6.Hidden = false;

            var s8 = new Card("8", 'S', 8);
            s8.Hidden = false;

            var dJ = new Card("J", 'D', 10);

            Console.WriteLine($"You have been dealt: {GetCardDescription(c4)}, {GetCardDescription(h6)}");
            Console.WriteLine($"House has been dealt: {GetCardDescription(s8)}, { GetCardDescription(dJ)}");
            Console.WriteLine();

            Console.WriteLine("What do you want to do?");
            Console.WriteLine("Choose: 1 - To take another card");
            Console.WriteLine("Choose: 2 - To finish");
            Console.WriteLine();
            Console.WriteLine("I choose: 1");
            Console.WriteLine();

            var s4 = new Card("4", 'S', 4);
            s4.Hidden = false;

            var hT = new Card("T", 'H', 10);

            Console.WriteLine($"You have been dealt: {GetCardDescription(s4)}");
            Console.WriteLine($"House has been dealt: {GetCardDescription(hT)}");
            Console.WriteLine();

            Console.WriteLine("What do you want to do?");
            Console.WriteLine("Choose: 1 - To take another card");
            Console.WriteLine("Choose: 2 - To finish");
            Console.WriteLine();
            Console.WriteLine("I choose: 2");
            Console.WriteLine();

            Console.WriteLine("You have 14 points vs. house 17 points");
            Console.WriteLine("House wins!");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press any key");
            Console.ReadKey();
        }

        public static string GetCardDescription(Card card)
        {
            return card.Hidden ? "[?]" : card.Description;
        }
    }
}
