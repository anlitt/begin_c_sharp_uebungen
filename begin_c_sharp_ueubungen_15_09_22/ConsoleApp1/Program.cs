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
            Console.WriteLine("Bitte gebe mir einen Text deiner Wahl");
            string entry = Console.ReadLine();
            int length = entry.Length;
            Console.WriteLine("Dein Text ist " + length + " Zeichen lang");
            

            Console.ReadLine();
        }
    }
}
