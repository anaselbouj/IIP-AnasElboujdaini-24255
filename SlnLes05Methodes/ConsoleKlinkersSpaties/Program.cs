using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleKlinkersSpaties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef een tekst: ");
            string text = Console.ReadLine();
            int aantalklinkers = AantalKlinkers(text);
            int aantalspaties = AantalSpaties(text);
            Console.WriteLine($"Deze tekst bevat {aantalklinkers} klinkers en {aantalspaties} spaties");
            Console.Write("In geheimschrift: ");
            string geheimschrift = NaarGeheimschrift(text);
            Console.WriteLine(geheimschrift);

            Console.ReadLine();
        }

        static int AantalKlinkers(string text)
        {
            int aantalklinkers = 0;
            foreach (char c in text)
            {
                if (IsKlinker(c))
                {
                    aantalklinkers++;
                }
            }
            return aantalklinkers;
        }

        static int AantalSpaties(string text)
        {
            int aantalspaties = 0;
            foreach (char c in text)
            {
                if (c == ' ')
                {
                    aantalspaties++;
                }
            }
            return aantalspaties;
        }

        static string NaarGeheimschrift(string text)
        {
            char[] geheimschriftArray = new char[text.Length];
            for (int i = 0; i < text.Length; i++)
            {
                char c = text[i];
                if (c != ' ')
                {
                    int verschoven = (int)c + 1;
                    geheimschriftArray[i] = (char)verschoven;
                }
                else
                {
                    geheimschriftArray[i] = ' ';
                }
            }
            return new string(geheimschriftArray);
        }

        static bool IsKlinker(char c)
        {
            char[] klinkers = { 'a', 'e', 'i', 'o', 'u', 'y', 'A', 'E', 'I', 'O', 'U', 'Y' };
            foreach (char klinker in klinkers)
            {
                if (c == klinker)
                {
                    return true;
                }
            }
            return false;
        }
    }
}

