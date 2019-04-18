using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Auto
    {
        private string farbe;
        public string Farbe
        {
            get
            {
                return farbe;
            }
            set
            {
                if (value != "Rot")
                {
                    throw new Exception("Es gibt nur rote Autos!");
                }
                farbe = value;
            }
        }
    }
}
