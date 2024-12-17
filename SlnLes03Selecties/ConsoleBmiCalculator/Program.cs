using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBmiCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BMI CALCULATOR");
            Console.WriteLine("===============");
            Console.Write("Lengte (in cm) : ");
            double lengte = Convert.ToDouble(Console.ReadLine());
            Console.Write("Gewicht (in kg) : ");
            double gewicht = Convert.ToDouble(Console.ReadLine());
            double bmi = gewicht / ((lengte / 100) * (lengte / 100));
            Console.WriteLine($"Je BMI bedraagt: {Math.Round(bmi, 1) + Environment.NewLine}");

            if (bmi < 18.5)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Je hebt ondergewicht");
            }
            else if (bmi < 25)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Je gewicht is normaal");
            }
            else if (bmi < 30)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Je hebt overgewicht");
            }
            else if (bmi >= 30)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Je hebt obesitas");
            }
            Console.ReadLine();
        }
    }
}
