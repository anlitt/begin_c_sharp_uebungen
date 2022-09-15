using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bitte nenne mir eine Kommazahl");

            double Zahl1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Bitte nenne mir eine zweite Kommazahl");
            double Zahl2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ich danke dir");
            double Ergebnis = Zahl1 + Zahl2;
            Console.WriteLine("Ich kann dir sagen,dass " + Zahl1 + " und " + Zahl2 + " insgesamt " + Ergebnis + " ergibt.");

            

            Console.ReadLine();
        }
    }
}
