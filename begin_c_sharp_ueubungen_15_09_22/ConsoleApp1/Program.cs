using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace uebungen_c_sharp_150922
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //aufgabe 2
            List<int> liste_1 = new List<int>() { 5,3,7};
            Console.WriteLine("Möchtest du weitere Zahlen hinzufügen?");
            int eingabe2 = 0;
            string eingabe = " ";
            while(true)
            {
                Console.WriteLine("nenne mir eine Zahl, die ich der Liste hinzufügen soll. Wenn keine Zahl hinzugefügt werden soll, drücke Leertaste und dann enter");
                eingabe = Console.ReadLine();
                if (eingabe == " ")
                {
                    Console.WriteLine("keine weiteren Zahlen werden der Liste hinzugefügt. Abbruch");
                    break;
                }
                else
                {
                    eingabe2 = Convert.ToInt32(eingabe);
                    liste_1.Add(eingabe2);
                    Console.WriteLine(eingabe2 + " wird deiner Liste hinzugefügt");

                }

            }




            {

            }
            {

            }


            
            
            
           
        }
        


    }
}