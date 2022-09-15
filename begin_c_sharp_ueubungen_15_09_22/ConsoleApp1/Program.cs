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
            Console.WriteLine("Welche Zahl möchtest du addieren? ");
            int Zahl1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Mit welcher Zahl möchtest du diese erste Zahl addieren?");
            int Zahl2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Das Ergebnis ist:");
            int Ergebnis = Zahl1 + Zahl2;
            Console.WriteLine(Ergebnis);
            

            Console.ReadLine();
        }
    }
}
