namespace Blackjack.Core
{
    public class Card
    {
        public string Description => _rank + _suite;

        public bool Hidden { get; set; } = true;

        private readonly string _rank;

        private readonly char _suite;

        private readonly int _points;

        public Card(string rank, char suite, int points)
        {
            _rank = rank;
            _suite = suite;
            _points = points;
        }        
    }
}
