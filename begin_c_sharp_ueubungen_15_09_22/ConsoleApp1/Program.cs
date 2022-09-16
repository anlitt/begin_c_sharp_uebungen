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
            //for-Schleifen Aufgaben: aufgabe 4
            Console.WriteLine("Wie viel Zahlen möchtest du in deinem int-array haben?");
            int anzahl_plaetze = Convert.ToInt32(Console.ReadLine());
            int[] anzahl = new int[anzahl_plaetze];
            for (int i = 0; i < anzahl.Length; i++)
            {
                Console.WriteLine("Welche Zahl soll in deinem Array vorkommen?");
                int zahl = Convert.ToInt32(Console.ReadLine());
                //oder : anzahl[i]=Convert.ToInt32(Console.ReadLine());
                anzahl[i] = zahl;

            }

            Console.WriteLine();
            foreach (int i in anzahl) { Console.WriteLine(i); }

            Console.ReadLine();
            }   
                

        }





    }
    

