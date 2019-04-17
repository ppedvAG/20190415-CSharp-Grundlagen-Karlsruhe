using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Himmelskörper
{
    class Program
    {
        static void Main(string[] args)
        {
            Himmelskörper hk1 = new Himmelskörper();
            Sonne sonne1 = new Sonne();
            // Polymorphie - Die Sonne kann dem Himmelskörper zugewiesen werden
            Himmelskörper hk2 = sonne1;

            Console.WriteLine("hk1");
            Console.WriteLine("----------------------------------");
            hk1.WerBinIch();
            hk1.WieVieleBinIch();
            Console.WriteLine("----------------------------------");
            Console.WriteLine("sonne1");
            Console.WriteLine("----------------------------------");
            sonne1.WerBinIch();
            sonne1.WieVieleBinIch();
            Console.WriteLine("----------------------------------");
            Console.WriteLine("hk2");
            Console.WriteLine("----------------------------------");
            hk2.WerBinIch();
            hk2.WieVieleBinIch();
            Console.WriteLine("----------------------------------");


            Console.ReadKey();
        }
    }
}
