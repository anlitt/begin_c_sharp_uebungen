using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uebungen_c_sharp_150922
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //array hat 5 stellen aber keine Zahlen dafür definiert, daher alle 0
            int[] zahlen = new int[5];

            //in dem array befinden sich die Zahlen 26, 8, 12, 3 und 6. Also nicht definiert wie viele Zahlen sonder vor allem welche
            int[] zahlen2 = new int[] { 26, 8, 12, 3, 6 };
            for (int i = 0; i < zahlen.Length; i++)
            {
                Console.WriteLine("Gebe mir eine Zahl für das Array!");
                zahlen[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("[");
            for (int i = 0; i < zahlen2.Length; i++)
            {
                Console.Write($" {zahlen[i]} / ");
            }
            Console.Write("]");
            Console.ReadLine();

        }





    }
    }

