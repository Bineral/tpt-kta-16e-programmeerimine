namespace DiceRoller
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("> /roll 3d6 2d8");
            Console.WriteLine();

            Dice d6 = Dice.D6;

            var total = 0;

            for (var i = 0; i < 3; i++)
            {
                var roll = d6.Roll();
                total += roll;

                Console.WriteLine($"1{ d6.Description }: { roll }");
            }

            Dice d8 = Dice.D8;
            for (var i = 0; i < 2; i++)
            {
                var roll = d8.Roll();
                total += roll;

                Console.WriteLine($"1{ d8.Description }: { roll }");
            }


            Console.WriteLine();
            Console.WriteLine($"Roll total: { total }");
            Console.WriteLine();
            Console.Write("> ");

            Console.ReadLine();
        }
    }
}
