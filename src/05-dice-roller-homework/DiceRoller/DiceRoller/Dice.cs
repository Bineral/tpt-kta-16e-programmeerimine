namespace DiceRoller
{
    using System;

    public class Dice
    {
        public int Sides { get; }

        public string Description { get; }

        private static Random Random { get; } = new Random();

        private Dice(int sides, string description)
        {
            this.Sides = sides;
            this.Description = description;
        }

        public static Dice D4 => new Dice(4, "d4");
        public static Dice D6 => new Dice(6, "d6");
        public static Dice D8 => new Dice(8, "d8");
        public static Dice D10 => new Dice(10, "d10");
        public static Dice D12 => new Dice(12, "d12");
        public static Dice D20 => new Dice(20, "d20");

        public static Dice FromString(string description)
        {
            switch(description)
            {
                case "d4": return Dice.D4;
                case "d6": return Dice.D6;
                case "d8": return Dice.D8;
                case "d10": return Dice.D10;
                case "d12": return Dice.D12;
                case "d20": return Dice.D20;
                default: throw new InvalidOperationException();

            }
        }


        public int Roll()
        {
            return Dice.Random.Next(1, this.Sides + 1); // max value is exlusive, so we have to add +1
        }

       
    }
}
