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
            Console.WriteLine("Bitte nenne mir eine Zahl");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ich werde nun rückwärts zählen");
            while (age > 0)
            {
                age--;
                Console.WriteLine(age);
            }

            Console.ReadLine();
        }
    }
}
