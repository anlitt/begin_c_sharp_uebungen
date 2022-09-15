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
            int x = 0;
            for(int i=0;i<=20; i++)
            {
                int sum = x + i;
                Console.WriteLine(x + "+" + i +" ist gleich" + sum);
                x = sum;
            }

            Console.ReadLine();
        }
    }
}
