using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReceipt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Taco Palenque");
            Console.WriteLine("1200 Main ST.");
            Console.WriteLine("---------------------------------------------------");

            double total = 0;

            while(true)
            {
                Console.Write("Enter price of food item [-1 to quit]: ");
                string input = Console.ReadLine();

                double value = double.Parse(input);

                if (value == -1)
                    break;

                total = total + value;
            }

            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine($"Subtotal: €{total}");
            Console.WriteLine($"15.00 % Gratuity: €{total * 0.15:F2}");
            Console.WriteLine($"Total: €{total - (total * 0.15):F2}");

            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}
