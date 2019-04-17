using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner
{
    class Program
    {
        static void Main(string[] args)
        {
            Rechner rechner = new Rechner("Multiplizieren");

            Console.WriteLine(rechner.Rechne(4,7));

            Console.ReadKey();
        }
    }
}
