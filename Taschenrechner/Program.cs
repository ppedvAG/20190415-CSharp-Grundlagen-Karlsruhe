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
            Rechner rechner = new Rechner("Modulo");

            Console.WriteLine(rechner.Rechne(10,5));

            Console.ReadKey();
        }
    }
}
