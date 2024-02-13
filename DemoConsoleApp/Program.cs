namespace DemoConsoleApp;

using System;

class Program
{
    static void Main(string[] args)
    {
        // Vraag de gebruiker om twee getallen in te voeren
        Console.WriteLine("Voer het eerste getal in:");
        double getal1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Voer het tweede getal in:");
        double getal2 = Convert.ToDouble(Console.ReadLine());

        // Voer de rekenkundige bewerkingen uit
        double som = getal1 + getal2;
        double verschil = getal1 - getal2;
        double product = getal1 * getal2;
        double quotient = getal1 / getal2;
        double modulus = getal1 % getal2;

        // Geef de resultaten weer
        Console.WriteLine($"Som: {getal1} + {getal2} = {som}");
        Console.WriteLine($"Verschil: {getal1} - {getal2} = {verschil}");
        Console.WriteLine($"Product: {getal1} * {getal2} = {product}");
        Console.WriteLine($"Quotient: {getal1} / {getal2} = {quotient}");
        Console.WriteLine($"Modulus: {getal1} % {getal2} = {modulus}");

        // Wacht tot de gebruiker op Enter drukt voordat het
        // programma wordt afgesloten
        Console.ReadLine();
    }
}

