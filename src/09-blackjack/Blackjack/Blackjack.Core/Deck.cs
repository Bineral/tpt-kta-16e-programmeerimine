namespace Blackjack.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Deck
    {
        private readonly List<Card> _cards;

        public Deck(List<Card> cards)
        {
            _cards = cards;
        }

        public static Deck C36()
        {
            throw new NotImplementedException();
        }

        public static Deck C52()
        {
            throw new NotImplementedException();
        }

        public Card Next()
        {
            // TODO: This will blow up if no cards left in the deck!
            var card = _cards.ElementAt(0);

            _cards.RemoveAt(0);

            return card;
        }
    }
}
