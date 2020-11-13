using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] cisla = { 800, 11, 50, 771, 649, 770, 240, 9, 456, 572 };

            int temp = 0;

            Console.Write("Na zacatku jsou cisla: ");
            for (int i = 0; i < cisla.Length; i++)
            {
                Console.Write(cisla[i] + " ");
            }

            Console.WriteLine();
            for (int i = 0; i < cisla.Length; i++)
            {
                for (int deleni = 0; deleni < cisla.Length - 1; deleni++)
                {
                    if (cisla[deleni] > cisla[deleni + 1])
                    {
                        temp = cisla[deleni + 1];
                        cisla[deleni + 1] = cisla[deleni];
                        cisla[deleni] = temp;
                        int y = i + 1;
                        Console.WriteLine("Krok " + y + ": " + cisla[deleni]);
                    }
                }
            }

            Console.Write("Na konci jsou cisla: ");
            for (int i = 0; i < cisla.Length; i++)
            {
                Console.Write(cisla[i] + " ");
            }

            Console.ReadKey();
        }
    }
}
