using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Parse_Input_To_Int
{
    class Program
    {
        static void Main(string[] args)
        {

            string a = "5";
            string b = "64";

            int arv = int.Parse(a);
            int s = Convert.ToInt32(a);

            Console.WriteLine($"Summa on: {(a + b)}");

            Console.ReadLine();
        }
    }
}
