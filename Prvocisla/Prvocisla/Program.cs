using System;

namespace Prvocisla
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadejte cele kladne cislo: ");
            Prvocisla();
            
            Console.ReadKey();
        }

        private static void Prvocisla()
        {
            string cislo = Console.ReadLine();
            int a;
            double aa;
            int c = 2;

            if (int.TryParse(cislo, out a))
            {
                int a2 = int.Parse(cislo);
                if (a >= 1)
                {
                    if (a % c != 0)
                    {
                        Console.WriteLine("\nCislo {0} je prvocislo.", cislo);
                    }
                    else if (a == 2)
                    {
                        Console.WriteLine("\nCislo {0} je prvocislo.", cislo);
                    }
                    else
                    {
                        Console.WriteLine("\nPrvocinitel/e cisla {0} jsou: ", cislo);

                        for (int b = 2; a > 1; b++)
                        {
                            if (a % b == 0)
                            {
                                int x = 0;
                                while (a % b == 0)
                                {
                                    a /= b;
                                    x++;
                                    
                                    Console.WriteLine(b);
                                }
                            }
                        }
                    }
                }
                else if (a < 1)
                {
                    Console.WriteLine("Zadavane cislo musi byt vetsi nez 0.");
                    Prvocisla();
                }
            }
            else if (double.TryParse(cislo, out aa))
            {
                if (aa >= 1)
                {
                    Console.WriteLine("Zadavane cislo musi byt cele cislo.");
                    Prvocisla();
                }
                else if (aa < 1)
                {
                    Console.WriteLine("Zadavane cislo musi byt cele cislo vetsi nez 0.");
                    Prvocisla();
                }
            }
            else
            {
                Console.WriteLine("Toto neni cislo.");
                Prvocisla();
            }
            
        }
    }
}
