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
            Console.WriteLine("Bitte nenne mir einen Text mit weniger als dreißig Zeichen du Vollidiot");
            string entry = Console.ReadLine();
            Console.WriteLine("Das ist dein Originaleintrag: " + entry);
            string replaced_entry = entry.PadRight(30,'y');
            Console.WriteLine("Das ist dein aufgefüllter Text: " + replaced_entry);



            

            Console.ReadLine();
        }
    }
}
