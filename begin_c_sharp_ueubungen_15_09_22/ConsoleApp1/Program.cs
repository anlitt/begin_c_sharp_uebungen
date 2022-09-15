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
            Console.WriteLine("Bitte nenne mir einen Text mit Semicolons");
            string entry = Console.ReadLine();
            Console.WriteLine("Das ist dein Originaltext: " + entry);
            string[]teilung = entry.Split(';');
            foreach (string teil in teilung)
            {
                Console.WriteLine(teil);
            }




            
            



            

            Console.ReadLine();
        }
    }
}
