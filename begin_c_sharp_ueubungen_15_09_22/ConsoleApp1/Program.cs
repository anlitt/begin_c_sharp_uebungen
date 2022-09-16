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
            //rückgabetyp und variablentyp, der gespeichert werden soll, müssen übereinstimmen
            Console.WriteLine("Wir holen uns jetzt eine Zahl aus Number()");
            List<string> names = Number();//methode Number ohne Parameter
            foreach (var name in names)
            {
                Console.WriteLine("Bitte gib mir eine erste Zahl");
                int zahl1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Bitte gib mir eine zweite Zahl");
                int zahl2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Was möchtest du machen?");
                string op = Console.ReadLine();
                switch (op)
                {
                    case "+":
                        int ergebnis = Add(zahl1, zahl2);
                        Console.WriteLine("Das Ergebnis ist " + ergebnis);
                        break;
                    case "-":
                        int result = Substraction(zahl1, zahl2);
                        Console.WriteLine("Das Ergebnis ist " + result);
                        break;
                    case "*":
                        int ergebnis1 = Multiply(zahl1, zahl2);
                        Console.WriteLine("Das Ergebnis ist " + ergebnis1);
                        break;
                    case "/":
                        double ergebnis2 = Division(zahl1, zahl2);
                        Console.WriteLine("Das Ergebnis ist " + ergebnis2);
                        break;
                }

                
                
                Console.ReadLine();
            }
             
        } 
        static int Add(int z1, int z2)
            {
                int summe = z1 + z2;
            return summe;
            }
        static int Substraction(int z1, int z2)
        {
            int differenz = z1 + z2;
            return differenz;
        }
        static int Multiply(int z1, int z2)
        {
            int produkt = z1 * z2;
            return produkt;
        }
        static double Division(double z1, double z2)
        {
            double quotient = z1/ z2;
            return quotient;
        }
        //static Rückgabentyp MethodenName (parameter)
        static List<string> Number()
        {
            List<string> name = new List<string>();
            name.Add("Abc");
            //Rückgabevariante
            return name;
            //Rückgabewert, Rückgabevariable und Speicherort müssen vom selben Typ sein
        }
        


    }
}