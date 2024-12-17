using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRadenGrenzen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ASCII art
            Console.WriteLine(" ___    _   ___  ___ _  _ \r\n | _ \\  /_\\ |   \\| __| \\| |\r\n |   / / _ \\| |) | _|| .` |\r\n |_|_\\/_/ \\_\\___/|___|_|\\_|\r\n" + Environment.NewLine);

            // Boven en ondergrens vragen
            Console.WriteLine("Geef twee gehele getallen.");
            Console.Write("- getal 1: ");
            int getlal1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("- getal 2: ");
            int getlal2 = Convert.ToInt32(Console.ReadLine());

            // verwissel van waarden als getal1 groter is dan getal2
            if (getlal1 > getlal2)
            {
                int tmp = getlal1;
                getlal1 = getlal2;
                getlal2 = tmp;
            }

            // genereer random tussen getal1 en getal2
            Random rnd = new Random();
            int randomgetal = rnd.Next(getlal1, getlal2 + 1);

            // gok van de gebruiker
            Console.WriteLine($"Even denken... ja, ik heb een getal tussen {getlal1} en {getlal2} in mijn hoofd. ");
            Console.Write("Doe een gok: ");
            int gok = int.Parse(Console.ReadLine());

            if (gok == randomgetal)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("JUIST! Goed geraden!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("FOUT!");

                if (Math.Abs(gok - randomgetal) <= 2)
                {
                    Console.ResetColor();
                    Console.WriteLine("Je zat er nochtans niet ver af!");
                }
            }
            Console.ReadLine();
        }
    }
}
