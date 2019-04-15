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
            int eingabe = int.Parse(Console.ReadLine());

            if (eingabe < zufallsZahl)
            {
                Console.WriteLine("Die eingegebene Zahl ist kleiner");
                eingabe += 100;
            }
            else if (eingabe > zufallsZahl)
            {
                Console.WriteLine("Die eingegebene Zahl ist größer");
            }
            else if (eingabe == zufallsZahl)
            {
                Console.WriteLine("Die Zahlen sind gleich");
            }
            

            Console.ReadKey();
        }
    }
}
