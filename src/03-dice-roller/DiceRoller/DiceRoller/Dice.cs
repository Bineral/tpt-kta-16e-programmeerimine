namespace DiceRoller
{
    using System;

    public class Dice
    {
        public int Sides { get; }

        private Random Random { get; } = new Random();

        public Dice(int sides)
        {
            this.Sides = sides;
        }

        public int Roll()
        {
            return this.Random.Next(1, this.Sides + 1); // max value is exlusive, so we have to add +1
        }
    }
}
