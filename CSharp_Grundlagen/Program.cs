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
            Person p = new Person("Tom", "Müller");
            Console.WriteLine($"Der Vorname der Person lautet: {p.Vorname}.");
            Gärtner g = new Gärtner("Jakob", "Meyer");
            Console.WriteLine($"Der Vorname der Person lautet: {g.Vorname}.");
            g.Gießen();
            Console.ReadKey();
        }
    }
}
