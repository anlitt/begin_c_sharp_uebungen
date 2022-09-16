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
            //taschenrechner
            Console.WriteLine("Bitte gebe mir eine Zahl");
            double zahl1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Bitte gib mir noch eine zweite Zahl");
            double zahl2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Was willst du machen ?");
            string op = Console.ReadLine();
            double ergebnis = 0;
            switch (op)
            {
                case "+":
                     ergebnis = zahl1 + zahl2;
                    Console.WriteLine("Dein Ergebnis ist " + ergebnis);
                    break;
                case "-":
                     ergebnis = zahl1 - zahl2;
                    Console.WriteLine("Dein Ergebnis ist " + ergebnis);
                    break;
                case "*":
                    ergebnis = zahl1 * zahl2;
                    Console.WriteLine("Dein Ergebnis ist " + ergebnis);
                    break;
                case "/":
                    ergebnis = zahl1 / zahl2;
                    Console.WriteLine("Dein Ergebnis ist " + ergebnis);
                    break;
                case "%":
                    ergebnis = zahl1 % zahl2;
                    Console.WriteLine("Dein Ergebnis ist " + ergebnis);
                    break;  
            }
            Console.WriteLine("Ich hoffe ich konnte dir helfen. ;)");
            Console.ReadLine();
            }   
                

        }





    }
    

