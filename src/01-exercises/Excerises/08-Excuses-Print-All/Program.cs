using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Excuses_Print_All
{
    class Program
    {
        static void Main(string[] args)
        {
            var excuses = new[] {"Koer sõi kodutöö ära", "Ema ei luba arvutis tiksuda"};

            // use foreach instead
            int i = 0;
            foreach (var excuse in excuses)
            {
                Console.WriteLine($"{i + 1}. {excuse}");
                i++;
            }

            //for (int i = 0; i < excuses.Length; i++)
            //{
            //    Console.WriteLine($"{i + 1}. {excuses[i]}");
            //}

            Console.ReadLine();
        }
    }
}
