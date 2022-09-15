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
            Console.WriteLine("Bitte nenne mir einen Text, bei dem vor und nach dem Text Leerzeichen eingebaut sind");
            string entry = Console.ReadLine();
            Console.WriteLine("Das ist dein Originaltext: " + entry);
            string ohne_leerzeichen = entry.Trim(' ');
            Console.WriteLine("Hier ist dein Text ohne Leerzeichen. Ich hoffe du bist jetzt glücklich!!");
            Console.WriteLine(ohne_leerzeichen);
            



            

            Console.ReadLine();
        }
    }
}
