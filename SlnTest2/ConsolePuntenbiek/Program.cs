using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("PUNTENBOEK");

        // Vraag het aantal studenten
        Console.Write("Aantal studenten: ");
        int aantalStudenten = int.Parse(Console.ReadLine());

        // Lijsten voor de gegevens
        List<string> namen = new List<string>();
        List<int> portfolioScores = new List<int>();
        List<int> projectScores = new List<int>();

        // Gegevens inlezen
        for (int i = 0; i < aantalStudenten; i++)
        {
            Console.Write($"Student {i + 1} naam: ");
            string naam = Console.ReadLine();
            namen.Add(naam);

            Console.Write($"Score portfolio (op 20) voor {naam}: ");
            int portfolioScore = int.Parse(Console.ReadLine());
            portfolioScores.Add(portfolioScore);

            Console.Write($"Score project (op 20) voor {naam}: ");
            int projectScore = int.Parse(Console.ReadLine());
            projectScores.Add(projectScore);
        }

        Console.WriteLine("\nSCORES");

        // Resultaten berekenen
        List<string> geslaagden = new List<string>();
        for (int i = 0; i < aantalStudenten; i++)
        {
            double eindScore = (portfolioScores[i] + projectScores[i]) / 2.0;
            string status = eindScore >= 10 ? "Geslaagd" : "Niet geslaagd";

            Console.WriteLine($"{namen[i]}: {eindScore:F1}/20 ({status})");

            if (eindScore >= 10)
            {
                geslaagden.Add(namen[i]);
            }
        }

        // Geslaagden weergeven
        Console.WriteLine("\nGeslaagd: " + string.Join(", ", geslaagden));
    }
}
