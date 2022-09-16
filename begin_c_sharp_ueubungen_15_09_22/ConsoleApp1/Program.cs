using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace uebungen_c_sharp_150922
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //casino aufgaben
            Random k = new Random();
            int Zufallszahl = k.Next(0, 36);
            int Rundenzahl = 0;
            Console.WriteLine("Mein Freund, du startest mit 10,000 Dollar");
            while (true)
            {
                int Guthaben = 10000;
                foreach (
                {
                
                    if (Guthaben >= 10000)
                    {
                        Console.WriteLine("Du musst 10 Euro setzen");
                        Guthaben = Guthaben - 10;
                        if (Zufallszahl % 2 == 0)
                        {
                            Console.WriteLine("Herzlichen Glückwunsch du hast gewonnen");
                            Guthaben = Guthaben + 20;


                        }
                    }
                
                    
                }
            }
                

                
            }
            

            
            
            
            Console.ReadLine();




            
            
            
           
        }
        


    }
}