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
            int[] zahlenListe = new int[] { 2, 5, 6, 1, 4 };

            for (int i = 0; i < zahlenListe.Length; i++)
            {
                Console.WriteLine(zahlenListe[i]);
            }

            foreach (var item in zahlenListe)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
