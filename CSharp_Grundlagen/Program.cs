using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Grundlagen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            float eingegebeneZahl;


            while (!float.TryParse(Console.ReadLine(), out eingegebeneZahl))
            {
                Console.WriteLine("Bitte gib eine gültige Zahl ein");
            }

            Console.WriteLine($"Die eingegebene Zahl lautet: {eingegebeneZahl}"); // Gib die Zahl als Float aus
            Console.WriteLine($"Die eingegebene Zahl als Integer lautet: {(int)eingegebeneZahl}"); // Gib die Zahl als Integer aus
            Console.WriteLine($"Die eingegebene Zahl gerundeten als Integer lautet: {Math.Round(eingegebeneZahl, MidpointRounding.AwayFromZero)}"); // Gib die Zahl als gerundeten Integer aus
            Console.ReadKey();
        }
    }
}
