namespace DiceRoller
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("> ");
            string input = Console.ReadLine();

            Console.WriteLine();

            var parser = new RollCommandParser();
            List<Dice> dices = parser.Parse(input);

            DiceRoller diceRoller = new DiceRoller();
            List<DiceRoll> diceRolls = diceRoller.Roll(dices);

            foreach (var diceRoll in diceRolls)
            {
                Console.WriteLine($"1{diceRoll.Dice}: {diceRoll.Value}");
            }

            Console.WriteLine();
            Console.WriteLine($"Roll total: {diceRolls.Sum(x => x.Value)}");
            Console.WriteLine();
            Console.Write("> ");

            Console.ReadLine();
        }
    }
}
