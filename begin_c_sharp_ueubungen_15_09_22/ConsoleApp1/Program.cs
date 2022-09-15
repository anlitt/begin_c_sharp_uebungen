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
            string replaced_entry = entry.Replace("U", "G").Replace("u", "g");
            Console.WriteLine("Dein geänderter Text ist:");
            Console.WriteLine(replaced_entry);

            

            Console.ReadLine();
        }
    }
}
