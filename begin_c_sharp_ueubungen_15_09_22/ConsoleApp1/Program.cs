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
            foreach(var name in names)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine(); 
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