using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bitte gib eine Zahl ein:");
            string farbe;
            Auto auto = new Auto();

            try
            {
                auto.Farbe = "Rot"; // Das wirft eine Exception
            }
            catch (FarbException e)
            {
                Console.WriteLine("Bitte gib eine neue Farbe ein:"); // Wenn wir was anderes als Rot eingeben, haben wir ein Problem
                auto.Farbe = Console.ReadLine();
                Console.WriteLine($"Eine FarbException wurde abgefangen! Msg: {e.Message}");
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception");
            } finally
            {
                Console.WriteLine("Der Finally-Block wird ausgeführt");
                // Hier könnte man den Datenstream schließen (wenn es z.B. eine Datei wäre)
            }

            Console.WriteLine($"Die Farbe vom Auto ist: {auto.Farbe}!");

            try
            {
                farbe = Console.ReadLine();
            } catch(FormatException e)
            {
                Console.WriteLine("Eine FormatException wurde abgefangen!");
            } catch(Exception e) // Jede Exception wird hier abgefangen
            {
                Console.WriteLine("Eine Exception wurde abgefangen!");
            }

            Console.ReadKey();
        }
    }
}
