using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Sifra
{
    class Program
    {
        static string radek;
        static int p;
        static int cislo;

        static int pozice;
        static int poz;

        static int azL;
        static int aZL;

        static char[] az;
        static char[] aZ;
        static char[] text;
        static void Main(string[] args)
        {
            Read();
            
            az = Enumerable.Range('a', 'z' - 'a' + 1).Select(i => (Char)i).ToArray();
            aZ = Enumerable.Range('A', 'Z' - 'A' + 1).Select(i => (Char)i).ToArray();
            text = radek.ToCharArray();

            Write();

            Console.ReadKey();
        }

        static void Read()
        {
            StreamReader inFile = new StreamReader("in.txt");
            radek = inFile.ReadLine();
            inFile.Close();
        }

        static void Write()
        {
            Console.Write("O kolik chcete posunout pismena?: ");
            string num = Console.ReadLine();
            double p2;

            if (int.TryParse(num, out p))
            {
                if(p >= 1)
                {
                    RealWrite();
                }
                else if (p < 1)
                {
                    Console.WriteLine("Zadavane cislo musi byt vetsi nez 0.");
                    Write();
                }
            }
            
            else if (double.TryParse(num, out p2))
            {
                if (p2 >= 1)
                {
                    Console.WriteLine("Zadavane cislo musi byt cele cislo.");
                    Write();
                }
                else if (p2< 1)
                {
                    Console.WriteLine("Zadavane cislo musi byt cele cislo vetsi nez 0.");
                    Write();
                }
            }
            else
            {
                Console.WriteLine("Toto neni cislo.");
                Write();
            }
        }

        static void RealWrite()
        {
            StreamWriter outFile = new StreamWriter ("out.txt");

            for (int i = 0; i < text.Length; i++)
            {
                pozice = Array.IndexOf(az, text[i]);
                poz = pozice + p;
                
                azL = az.Length;
                aZL = aZ.Length;

                if (az.Contains(text[i]))
                {
                    if (poz > azL)
                    {
                        AaZ();
                        if (cislo == azL)
                        {
                            outFile.Write(az[cislo-1]);
                        }
                        else
                        {
                            outFile.Write(az[cislo]);
                            Console.WriteLine(".");
                        }
                    }
                    else if(poz < azL)
                    {
                        outFile.Write(az[poz]);
                        Console.WriteLine(".");
                    }
                }
                else if (aZ.Contains(text[i]))
                {
                    if (poz > aZL)
                    {
                        AAZ();
                        if (cislo == aZL)
                        {
                            outFile.Write(aZ[cislo - 1]);
                        }
                        else
                        {
                            outFile.Write(aZ[cislo]);
                            Console.WriteLine(".");
                        }
                    }
                    else if (poz < aZL)
                    {
                        outFile.Write(aZ[poz]);
                        Console.WriteLine(".");
                    }
                }
                else if (az.Contains(text[i]) == false && az.Contains(text[i]) == false)
                {
                    outFile.Write(text[i]);
                    Console.WriteLine(".");
                }
                else
                {
                    Console.WriteLine("Nejak to nejde...");
                }
            }

            outFile.Close();
            Console.WriteLine("\nHotovo!");
        }

        static void AaZ()
        {
            cislo = poz - azL;
            int o = cislo;

            if (cislo > azL)
            {
                hop:
                cislo = o - azL;

                if (cislo > azL)
                {
                    o = cislo;
                    goto hop ;
                }
            }
        }

        static void AAZ()
        {
            cislo = poz - aZL;
            int o = cislo;

            if (cislo > aZL)
            {
                skok:
                cislo = o - aZL;

                if (cislo > aZL)
                {
                    o = cislo;
                    goto skok;
                }
            }
        }
    }
}