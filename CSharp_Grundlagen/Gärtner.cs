using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Grundlagen
{
    class Gärtner: Person, ITier
    {
        public Gärtner(string vorname, string name): base(vorname, name)
        {
            Gießen();
        }

        public int AnzahlBeine { get; set; }

        public void Gießen()
        {
            Laufen();
            Console.WriteLine("Die Pflanzen haben jetzt genug Wasser.");
        }

        public void Laufen()
        {
            Console.WriteLine("Ich bin 5 Meter gelaufen.");
        }
   
        public override string ToString()
        {
            return $"Ich bin ein Gärtner und heiße {Vorname}";
        }
    }
}
