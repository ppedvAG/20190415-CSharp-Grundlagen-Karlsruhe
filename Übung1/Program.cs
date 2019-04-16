using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Übung1
{
    class Program
    {
        static void Main(string[] args)
        {
            int eingegebeneZahl;
            int gültigerMaxBereich = 10;
            int gültigerMinBereich = 0;

            do
            {
                Console.WriteLine("Bitte Punktzahl eingeben:");
                int.TryParse(Console.ReadLine(), out eingegebeneZahl);
                //Überprüfe ob die eingegebene Zahl gültig ist
                if(eingegebeneZahl <= gültigerMaxBereich && eingegebeneZahl >= gültigerMinBereich) {
                    switch (eingegebeneZahl)
                    {
                        case 10:
                            {
                                Console.WriteLine("Ergebnis: Sehr gut");
                                break;
                            }
                        case 9:
                            {
                                Console.WriteLine("Ergebnis: gut");
                                break;
                            }
                        case 8:
                            {
                                Console.WriteLine("Ergebnis: Befriedigend");
                                break;
                            }
                        case 7:
                            {
                                Console.WriteLine("Ergebnis: Ausreichend");
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("Ergebnis: Leider nicht genügend Punkte erreicht");
                                break;
                            }
                    }                    
                } else if(eingegebeneZahl == -1)
                {
                    //hier wird abgebrochen
                } else
                {
                    Console.WriteLine("Ungültige Eingabe");
                }
 
            }
            while (eingegebeneZahl != -1);
            Console.ReadKey();
        }
    }
}
