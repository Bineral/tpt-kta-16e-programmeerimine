namespace DiceRoller
{
    using System;

    public class Dice
    {
        public int Sides { get; }

        public string Description { get; }

        private Random Random { get; } = new Random();

        public Dice(int sides, string description)
        {
            this.Sides = sides;
            this.Description = description;
        }

        public int Roll()
        {
            return this.Random.Next(1, this.Sides + 1); // max value is exlusive, so we have to add +1
        }
    }
}
