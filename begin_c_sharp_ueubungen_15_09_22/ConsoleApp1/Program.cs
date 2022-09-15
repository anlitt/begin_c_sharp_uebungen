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
            Console.WriteLine("Bitte nenne mir Text");
            string entry = Console.ReadLine();
            string wahr = "abc";
            bool contains = entry.Contains(wahr);
            if (contains)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("False.Try again");
            }
            Console.WriteLine("Danke für deine Teilnahme");

          



            
            



            

            Console.ReadLine();
        }
    }
}
