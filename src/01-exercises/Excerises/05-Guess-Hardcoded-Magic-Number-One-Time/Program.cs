using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Guess_Hardcoded_Magic_Number_One_Time
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ma valin välja ühe suvalise numbri [1-100]. Proovi see ära arvata : )");

            int magicNumber = 33;

            Console.Write("Sina pakud: ");

            string input = Console.ReadLine();
            int value = int.Parse(input);

            if (value > magicNumber)
            {
                Console.WriteLine("Minu valitud number on väiksem");
            }

            if (value < magicNumber)
            {
                Console.WriteLine("Minu valitud number on suurem");
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }
    }
}
