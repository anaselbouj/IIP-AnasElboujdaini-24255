using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTafels
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            PrintTafel(4, 6);
            Console.WriteLine();
            PrintTafel(2, 5);
            Console.WriteLine();
            PrintTafel(7, 10);
            Console.WriteLine();
            int getal1 = VraagPositiefGetal();
            int getal2 = VraagPositiefGetal();
            Console.WriteLine(Maaktafel(getal1, getal2));
            Console.ReadLine();
        }
        private static int VraagPositiefGetal()
        {
            Console.Write("Geef een positief getal in: ");
            int getal = Convert.ToInt32(Console.ReadLine());

            while (getal <= 0)
            {
                Console.Write("Het getal moet positief zijn! Geef een getal in: ");
                getal = Convert.ToInt32(Console.ReadLine());
            }
            return getal;
        }

        static string Maaktafel(int get, int len)
        {
            string result = $"{get} x {len} tafel: \n";
            for (int i = 1; i <= len; i++)
            {
                int totaal = i * get;
                result += $"{get} x {i} = {totaal}\n";
            }
            return result;
        }
        static void PrintTafel(int get, int len)
        {
            Console.WriteLine(Maaktafel(get, len));
        }
    }
}
