namespace DiceRoller
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("> /roll 3d6 2d8");
            Console.WriteLine();

            Console.WriteLine("1d6: 5");
            Console.WriteLine("1d6: 3");
            Console.WriteLine("1d6: 2");
            Console.WriteLine("1d8: 6");
            Console.WriteLine("1d8: 4");

            Console.WriteLine();
            Console.WriteLine($"Roll total: 20");
            Console.WriteLine();
            Console.Write("> ");

            Console.ReadLine();
        }
    }
}
