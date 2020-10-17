using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonaccihoPosloupnost
{
    class Program
    {
		public static int Fib(int n)
		{
			if (n <= 1)
			{
				return n;
			}
			else
			{
				return Fib(n - 1) + Fib(n - 2);
			}
		}

		public static void Main(string[] args)
		{
            Console.WriteLine("Koilkate cislo Fibonacciho cisla chcete zjistit?");
            Posloupnost();

            Console.ReadKey();
        }

        private static void Posloupnost()
        {
            //int n = int.Parse(Console.ReadLine());
            string pocet = Console.ReadLine();
            int porovnavani;
            double porovnavani2;

            if (int.TryParse(pocet, out porovnavani))
            {
                if (porovnavani >= 0)
                {
                    Console.Write("\n" + porovnavani + ". cislo Fibnacciho cisla je cislo " + Fib(porovnavani) + ".");
                }
                else if (porovnavani < 0)
                {
                    Console.WriteLine("Zadavane cislo musi byt vetsi nez 0.");
                    Posloupnost();
                }
            }
            else if (double.TryParse(pocet, out porovnavani2))
            {
                if (porovnavani2 >= 0)
                {
                    Console.WriteLine("Zadavane cislo musi byt cele cislo.");
                    Posloupnost();
                }
                else if (porovnavani2 < 0)
                {
                    Console.WriteLine("Zadavane cislo musi byt cele cislo vetsi nez 0.");
                    Posloupnost();
                }
            }
            else
            {
                Console.WriteLine("Toto neni cislo.");
                Posloupnost();
            }
        }
    }
}
