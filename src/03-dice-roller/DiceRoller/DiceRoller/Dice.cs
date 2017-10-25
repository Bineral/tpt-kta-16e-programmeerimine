namespace DiceRoller
{
    using System;

    public class Dice
    {
        private Random Random { get; } = new Random();

        public int Roll(int sides)
        {
            return this.Random.Next(1, sides + 1); // max value is exclusive, so we have to add +1
        }
    }
}
