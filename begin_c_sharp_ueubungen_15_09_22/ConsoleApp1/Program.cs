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
            Console.WriteLine("Bitte nenne mir einen Text mit weniger als zwanzig Zeichen du Vollidiot");
            string entry = Console.ReadLine();
            string replaced_entry = entry.PadLeft(20,'y');
            Console.WriteLine(replaced_entry);



            

            Console.ReadLine();
        }
    }
}
