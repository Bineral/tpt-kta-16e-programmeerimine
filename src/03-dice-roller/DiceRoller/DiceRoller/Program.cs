namespace DiceRoller
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("> /roll 3d6 2d8");
            Console.WriteLine();

            Dice dice = new Dice();

            var total = 0;

            for (var i = 0; i < 3; i++)
            {
                var roll = dice.Roll(6);
                total += roll;

                Console.WriteLine($"1d6: { roll }");
            }

            for (var i = 0; i < 2; i++)
            {
                var roll = dice.Roll(8);
                total += roll;

                Console.WriteLine($"1d8: { roll }");
            }


            Console.WriteLine();
            Console.WriteLine($"Roll total: { total }");
            Console.WriteLine();
            Console.Write("> ");

            Console.ReadLine();
        }
    }
}
