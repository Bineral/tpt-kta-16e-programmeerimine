using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Guess_Random_Magic_Number_While
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ma valin välja ühe suvalise numbri [1-100]. Proovi see ära arvata : )");

            int magicNumber = new Random().Next(1, 101);
            //bool successfulGuess = false;

            while (true)
            {
                Console.Write("Sina pakud: ");

                string input = Console.ReadLine();
                int value = int.Parse(input);

                if (value == magicNumber)
                {
                    Console.WriteLine("Woot! You guessed it!");
                    break;
                }
                else if (value > magicNumber)
                {
                    Console.WriteLine("Minu valitud number on väiksem");
                }
                else // value < magicNumber
                {
                    Console.WriteLine("Minu valitud number on suurem");
                }
            }



            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }
    }
}
