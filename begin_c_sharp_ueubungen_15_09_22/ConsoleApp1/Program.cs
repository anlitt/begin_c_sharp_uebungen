using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            List<string> namen = new List<string>();
            
            Console.WriteLine("wie viele Namen möchtest du eintragen?");
            int anzahl = Convert.ToInt32(Console.ReadLine());
            for(int i=0; i<anzahl; i++)
            {
                Console.WriteLine("Gib einen Namen ein");
                namen.Add(Console.ReadLine());
             
            }
            Console.WriteLine("Deine Liste besteht aus folgenden Namen: ");   
            foreach (string name in namen)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("Ich hoffe ich konnte dir helfen");   
            
            



            Console.ReadLine();
        }
        



    }
}