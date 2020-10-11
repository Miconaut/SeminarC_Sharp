using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulacka2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Jakou pocetni operaci chcete provest? (+ - * /)");
            string znaminko = Console.ReadLine();

            Console.WriteLine("Napiste prvni cislo:");
            double cislo1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Napiste druhe cislo");
            double cislo2 = Convert.ToDouble(Console.ReadLine());

            if (znaminko == "+")
            {
                Console.WriteLine("{0} + {1} = {2}", cislo1, cislo2, cislo1 + cislo2);
            }
            else if (znaminko == "-")
            {
                Console.WriteLine("{0} - {1} = {2}", cislo1, cislo2, cislo1 - cislo2);
            }
            else if (znaminko == "*")
            {
                Console.WriteLine("{0} * {1} = {2}", cislo1, cislo2, cislo1 * cislo2);
            }
            else if (znaminko == "/")
            {
                Console.WriteLine("{0} / {1} = {2}", cislo1, cislo2, cislo1 / cislo2);
            }
            
            Console.ReadKey();
        }
    }
}
