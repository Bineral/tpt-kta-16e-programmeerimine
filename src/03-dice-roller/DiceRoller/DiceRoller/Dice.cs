namespace DiceRoller
{
    using System;

    public class Dice
    {
        public int Roll(int sides)
        {
            var random = new Random();

            return random.Next(1, sides + 1); // max value is exclusive, so we have to add +1
        }
    }
}
