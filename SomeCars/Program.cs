using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeCars
{
    class Program
    {
        static void Main(string[] args)
        {
            // Erstellen der Instanzen
            var auto1 = new Auto();
            var auto2 = new Auto();

            // Setzen der Eigenschaften
            auto1.Farbe = "Rosa"; // Das geht nicht, die Farbe ist ungültig
            auto1.Farbe = "Rot";
            auto1.Baujahr = 1899;
            auto2.Farbe = "Grün";
            auto2.Baujahr = 1820; // Das geht nicht, das Jahr muss größer gleich 1863 sein
            auto2.Baujahr = 2015;

            // Ausgabe der Werte
            Console.WriteLine($"Das 1. Auto hat die Farbe {auto1.Farbe} und wurde im Jahr {auto1.Baujahr} gebaut.");
            Console.WriteLine($"Das 2. Auto hat die Farbe {auto2.Farbe} und wurde im Jahr {auto2.Baujahr} gebaut.");

            // Ändern der Farbwerte
            auto1.Farbe = "Gelb";
            auto2.Farbe = "Blau";

            // Erneute Ausabe der Werte
            Console.WriteLine($"Das 1. Auto hat die Farbe {auto1.Farbe} und wurde im Jahr {auto1.Baujahr} gebaut.");
            Console.WriteLine($"Das 2. Auto hat die Farbe {auto2.Farbe} und wurde im Jahr {auto2.Baujahr} gebaut.");

            Console.ReadKey();
        }
    }
}
