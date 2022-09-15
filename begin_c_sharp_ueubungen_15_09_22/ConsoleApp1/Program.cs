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
            string trainees = "jonasb,phillip,marcello,andreas,robin,robert,marie,leon,erwin,jan,mona,lukas";
            Console.WriteLine(trainees);
            Console.WriteLine("Und hier die geteilte Liste:");
            string[] teilung = trainees.Split(',');
            Console.WriteLine("Bitte gebe mir einen Buchstaben, der herausgefiltert werden soll");
            string Buchstabe = Console.ReadLine();

            foreach (string trainee in teilung)
            {
                bool contains = trainee.Contains(Buchstabe);
                if (contains)
                {
                    Console.WriteLine(trainee);
                }

            
            }

            Console.ReadLine();
        }
    }
}
