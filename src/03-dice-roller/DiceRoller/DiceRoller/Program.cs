namespace DiceRoller
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("> /roll 3d6 2d8");
            Console.WriteLine();

            var random = new Random();

            for (var i = 0; i < 3; i++)
            {
                Console.WriteLine($"1d6: { random.Next(1, 7)}");
            }

            for (var i = 0; i < 2; i++)
            {
                Console.WriteLine($"1d8: { random.Next(1, 9)}");
            }


            Console.WriteLine();
            Console.WriteLine($"Roll total: 20");
            Console.WriteLine();
            Console.Write("> ");

            Console.ReadLine();
        }
    }
}
