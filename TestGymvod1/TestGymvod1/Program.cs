using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGymvod1
{
    class Program
    {
        static int ran2;
        static bool v;
        static void Main(string[] args)
        {
            Random r = new Random();
            int ran = r.Next();

            Console.Write("Zadejte 1. cislo: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Zadejte 2. cislo: ");
            int y = int.Parse(Console.ReadLine());

            ran2 = r.Next(x, y);

            Prvocislo();

            StreamWriter vysledek = new StreamWriter("vysledek.txt");
            // z nejakeho zahadneho duvodu to nevypisuje do konzole 
            // ale s breakpointem to do konzole vypisuje
            if (v == true)
            {
                Console.WriteLine("Cislo {0} je prvocislo.", ran2);
                vysledek.Write("Cislo {0} je prvocislo.", ran2);
            }
            else
            {
                Console.WriteLine("Cislo {0} neni prvocislo.", ran2);
                vysledek.Write("Cislo {0} neni prvocislo.", ran2);
            }
            vysledek.Close();
            Console.WriteLine("Hotovo!");
        }

        public static bool Prvocislo()
        {
            if (ran2 <= 1)
            {
                return false;
            }
            else if (ran2 % 2 == 0)
            {
                return ran2 == 2;

            }
            int n = (int)(Math.Sqrt(ran2) + 0.5);

            for (int i = 3; i <= n; i += 2)
            {
                if (ran2 % i == 0)
                {
                    return v = false;
                }
            }
            return v = true;
        }
    }
}