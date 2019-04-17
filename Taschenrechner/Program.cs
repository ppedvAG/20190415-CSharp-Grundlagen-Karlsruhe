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
            Rechner addiereRechner = new Rechner("Subtrahieren");

            Console.WriteLine(addiereRechner.Rechne(100, 5, 5, 8, 3));

            Console.ReadKey();
        }
    }
}
