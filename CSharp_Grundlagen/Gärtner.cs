using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Grundlagen
{
    class Gärtner: Person
    {
        public Gärtner(string vorname, string name): base(vorname, name)
        {
            Gießen();
        }
        public void Gießen()
        {
            Laufen();
            Console.WriteLine("Die Pflanzen haben jetzt genug Wasser.");
        }
    }
}
