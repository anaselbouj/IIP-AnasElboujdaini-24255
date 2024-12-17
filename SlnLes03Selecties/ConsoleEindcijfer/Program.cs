using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleEindcijfer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Berekening eindcijfer");
            Console.WriteLine("===================");

            Console.Write("Geef het cijfer dagelijks werk (op20): ");
            double dagelijkswerk = Convert.ToDouble(Console.ReadLine());
            Console.Write("Geef het Cijfer op het project (op 20): ");
            double project = Convert.ToDouble(Console.ReadLine());
            Console.Write("Geef het Cijfer op het examen (op 20): ");
            double examen = Convert.ToDouble(Console.ReadLine());

            dagelijkswerk = dagelijkswerk * 5;
            project = project * 5;
            examen = examen * 5;
            double totaal = dagelijkswerk * 0.3 + project * 0.2 + examen * 0.5;

            if (examen < 45)
            {
                totaal = Math.Min(totaal, examen);
            }

            Console.WriteLine(Environment.NewLine + $"Je eindcijfer is {totaal}%" + Environment.NewLine);
            totaal = Math.Round(totaal, 1);

            if (totaal < 50)
            {
                Console.WriteLine("-> onvoldoende");
            }
            else if (totaal >= 50 && totaal <= 67.5)
            {
                Console.WriteLine("-> voldoende");
            }
            else if (totaal >= 67.5 && totaal <= 75)
            {
                Console.WriteLine("->  onderscheiding ");
            }
            else if (totaal >= 75 && totaal <= 82.6)
            {
                Console.WriteLine("-> grote onderscheiding ");
            }
            else if (totaal >= 82.5)
            {
                Console.WriteLine("-> Grooste onderscheiding ");
            }
            Console.ReadLine();
        }
    }
}
