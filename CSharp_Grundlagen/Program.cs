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
            //Hier wird das Ergebnis in der Konsole ausgegeben
            Addiere(5, 4, true);

            //Hier wird das Ergebnis NICHT in der Konsole ausgegeben
            Addiere(1, 2);
            //Das ist nicht notwendig, da der Parameter standardmäßig schon auf 'False' gesetzt ist
            Addiere(7, 9, false);

            Console.ReadKey();
        }

       
        public static int Addiere(int a, int b, bool sollAusgeben = false)
        {
            int c = a + b;
            if(sollAusgeben)
            {
                Console.WriteLine($"Die Ausgabe ist {c}");
            }
            return c;
            Console.WriteLine("Das ist nicht sichtbar");
        }
    }
}
