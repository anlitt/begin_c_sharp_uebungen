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
            Random r = new Random();
            int random_zahl = r.Next(0, 100);
            Console.WriteLine("Bitte gebe mir eine Nummer zwischen 0 und hundert");
            while (true)
            {
                int Benutzerzahl = Convert.ToInt32(Console.ReadLine());
                if (Benutzerzahl == random_zahl)
                {
                    Console.WriteLine("Glückwunsch.Du hast gewonnen");
                    break;

                }
                else if (Benutzerzahl < random_zahl)
                {
                    Console.WriteLine("Die Zahl ist groesser als deine Zahl. Try again");
                }
                else if (Benutzerzahl > random_zahl)
                {
                    Console.WriteLine("Die Zahl ist kleiner als deine Zahl.Try again");
                }
            }
                

                Console.ReadLine();

        }
    }
}
