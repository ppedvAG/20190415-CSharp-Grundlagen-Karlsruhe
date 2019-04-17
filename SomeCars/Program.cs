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
            var auto1 = new PKW(1899, "Rot", 4);
            var auto2 = new PKW(2015, "Grün", 28);

            auto1.Farbe = "Rosa"; // Das geht nicht, die Farbe ist ungültig
            auto2.Baujahr = 1820; // Das geht nicht, das Jahr muss größer gleich 1863 sein

            // Ausgabe der Werte
            Console.WriteLine($"Das 1. Auto hat die Farbe {auto1.Farbe}, wurde im Jahr {auto1.Baujahr} gebaut und hat {auto1.Sitzplätze} Sitzplätze.");
            Console.WriteLine($"Das 2. Auto hat die Farbe {auto2.Farbe}, wurde im Jahr {auto2.Baujahr} gebaut und hat {auto2.Sitzplätze} Sitzplätze.");

            // Ändern der Farbwerte
            auto1.Farbe = "Gelb";
            auto2.Farbe = "Blau";

            // Erneute Ausabe der Werte
            Console.WriteLine($"Das 1. Auto hat die Farbe {auto1.Farbe}, wurde im Jahr {auto1.Baujahr} gebaut und hat {auto1.Sitzplätze} Sitzplätze.");
            Console.WriteLine($"Das 2. Auto hat die Farbe {auto2.Farbe}, wurde im Jahr {auto2.Baujahr} gebaut und hat {auto2.Sitzplätze} Sitzplätze.");

            Console.ReadKey();
        }
    }
}
