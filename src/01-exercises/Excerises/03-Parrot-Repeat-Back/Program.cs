using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Parrot_Repeat_Back
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olen papagoi programm");
            Console.Write("Sina ütled: ");

            string input = Console.ReadLine();

            Console.WriteLine($"Mina ütlen: {input}");

            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }
    }
}
