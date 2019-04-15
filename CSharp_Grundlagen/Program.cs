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

            int x = 5;
            // Bei ref muss die Variable vorher initialisiert werden
            // Bei out muss die Variable nur deklariert werden
            Addiere(5, 3, ref x);
            Console.WriteLine(x);

            Console.WriteLine(Addiere(5, 3));

            Console.ReadKey();
        }
        
        public static int Addiere(int a, int b)
        {
            return a+b;
            Console.WriteLine("Das ist nicht sichtbar");
        }

       public static int Addiere(int a, int b, int c)
        {
            return a + b + c;
        }

        //mit out und ref können wir mehrere Rückgabewerte zurückgeben
        public static void Addiere(int a, int b, ref int c)
        {
            // bei ref kann ich auf die Variable vor dem Setzen zugreifen
            // bei out kann ich vor dem Setzen nicht auf die Variable zugreifen
            Console.WriteLine(c);
            c = a + b;
            Console.WriteLine("Das ist sichtbar");
        }
    }
}
