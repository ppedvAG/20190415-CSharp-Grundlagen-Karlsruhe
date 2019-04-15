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
            Random generator = new Random();
            int zufallsZahl = generator.Next(1, 6);

            Console.WriteLine(zufallsZahl);

            int eingabe;
            int versuche = 0;

            do
            {
                eingabe = int.Parse(Console.ReadLine());
                versuche++;
                if (eingabe < zufallsZahl)
                {
                    Console.WriteLine("Die eingegebene Zahl ist kleiner");
                }
                else if (eingabe > zufallsZahl)
                {
                    Console.WriteLine("Die eingegebene Zahl ist größer");
                }
                else if (eingabe == zufallsZahl)
                {
                    Console.WriteLine($"Die Zahl wurde korrekt erraten, Versuche: {versuche}");
                }

            } while (eingabe != zufallsZahl);

            

            Console.ReadKey();
        }
    }
}
