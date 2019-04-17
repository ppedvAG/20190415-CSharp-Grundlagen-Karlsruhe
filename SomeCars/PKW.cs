using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeCars
{
    class PKW: Auto
    {
        public int Sitzplätze { get; set; }

        public PKW(int baujahr, string farbe, int sitzplätze): base(baujahr, farbe)
        {
            Sitzplätze = sitzplätze;
        }
    }
}
