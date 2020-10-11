using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Vectors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Koilk prvku budou mit vektory?");
            Porovnavani();

            Console.ReadKey();
        }
        
        private static void Porovnavani()
        {
            string pocet = Console.ReadLine();
            int porovnavani;
            double porovnavani2;
            if (int.TryParse(pocet, out porovnavani))
            {
                if (porovnavani >= 1)
                {
                    int pocetCislo = int.Parse(pocet);
                    double pocetCisloV = double.Parse(pocet);
                    double pocetCisloU = double.Parse(pocet);

                    Console.WriteLine("\nZadejte vektor v: ");
                    List<double> cisloV = new List<double>((int)pocetCisloV);
                    while (pocetCisloV > 0)
                    {
                        string delka = Console.ReadLine();
                        double porovnavaniV;
                        if (double.TryParse(delka, out porovnavaniV))
                        {
                            cisloV.Add(double.Parse(delka));
                            pocetCisloV--;
                        }
                        else
                        {
                            Console.WriteLine("Toto neni cislo.");
                            continue;
                        }
                    }

                    Console.WriteLine("Zadejte vektor u: ");
                    List<double> cisloU = new List<double>((int)pocetCisloU);
                    while (pocetCisloU > 0)
                    {
                        string delka = Console.ReadLine();
                        double porovnavaniU;
                        if (double.TryParse(delka, out porovnavaniU))
                        {
                            cisloU.Add(double.Parse(delka));
                            pocetCisloU--;
                        }
                        else
                        {
                            Console.WriteLine("Toto neni cislo.");
                            continue;
                        }
                    }

                    Console.WriteLine("\nSoucet vektoru v a vektoru u je: ");
                    Console.Write("(");
                    for (int i = 0; i < pocetCislo; i++)
                    {
                        double delkaV = cisloV[i];
                        double delkaU = cisloU[i];

                        Console.Write(delkaV + delkaU);
                        if (pocetCislo > 1 && i < pocetCislo - 1)
                        {
                            Console.Write(", ");
                        }
                    }
                    Console.Write(")");

                    Console.WriteLine("\nRozdil vektoru v a vektoru u je: ");
                    Console.Write("(");
                    for (int i = 0; i < pocetCislo; i++)
                    {
                        double delkaV = cisloV[i];
                        double delkaU = cisloU[i];

                        Console.Write(delkaV - delkaU);
                        if (pocetCislo > 1 && i < pocetCislo - 1)
                        {
                            Console.Write(", ");
                        }
                    }
                    Console.Write(")");

                    Console.WriteLine("\nRozdil vektoru u a vektoru v je: ");
                    Console.Write("(");
                    for (int i = 0; i < pocetCislo; i++)
                    {
                        double delkaV = cisloV[i];
                        double delkaU = cisloU[i];

                        Console.Write(delkaU - delkaV);
                        if (pocetCislo > 1 && i < pocetCislo - 1)
                        {
                            Console.Write(", ");
                        }
                    }
                    Console.Write(")");

                    Console.WriteLine("\nVelikost vektoru v je: ");
                    List<double> rozdilV = new List<double>((int)pocetCislo);
                    for (int i = 0; i < pocetCislo; i++)
                    {
                        double delkaV = cisloV[i];
                        double rozdil = delkaV * delkaV;
                        rozdilV.Add(rozdil);
                    }
                    double rozdilVektoruV = rozdilV.AsQueryable().Sum();
                    double rozdilVektoruVV = Math.Sqrt(rozdilVektoruV);
                    Console.WriteLine(rozdilVektoruVV);

                    Console.WriteLine("Velikost vektoru u je: ");
                    List<double> rozdilU = new List<double>((int)pocetCislo);
                    for (int i = 0; i < pocetCislo; i++)
                    {
                        double delkaU = cisloU[i];
                        double rozdil = delkaU * delkaU;
                        rozdilU.Add(rozdil);
                    }
                    double rozdilVektoruU = rozdilU.AsQueryable().Sum();
                    double rozdilVektoruUU = Math.Sqrt(rozdilVektoruU);
                    Console.WriteLine(rozdilVektoruUU);

                    Console.WriteLine("Skalarni soucin vektoru je: ");
                    List<double> soucin = new List<double>((int)pocetCislo);
                    for (int i = 0; i < pocetCislo; i++)
                    {
                        double delkaV = cisloV[i];
                        double delkaU = cisloU[i];
                        double soucinVektoru = delkaV * delkaU;
                        soucin.Add(soucinVektoru);
                    }
                    double soucinVektoruCelkem = soucin.AsQueryable().Sum();
                    Console.WriteLine(soucinVektoruCelkem);
                    if (soucinVektoruCelkem <= 0)
                    {
                        Console.WriteLine("Vektory na sebe jsou kolme.");
                    }
                    else
                    {
                        Console.WriteLine("Vektory na sebe nejsou kolme.");
                    }
                }
                else if (porovnavani < 1)
                {
                    Console.WriteLine("Pocet prvku vektoru musi byt vetsi nez 0.");
                    Porovnavani();
                }
            }
            else if (double.TryParse(pocet, out porovnavani2))
            {
                if (porovnavani2 >= 1)
                {
                    Console.WriteLine("Pocet prvku vektoru musi byt cele cislo.");
                    Porovnavani();
                }
                else if (porovnavani2 < 1)
                {
                    Console.WriteLine("Pocet prvku vektoru musi byt cele cislo vetsi nez 0.");
                    Porovnavani();
                }
            }
            else
            {
                Console.WriteLine("Toto neni cislo.");
                Porovnavani();
            }
        }
    }
}