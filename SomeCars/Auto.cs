using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeCars
{
    class Auto
    {
        private int baujahr;
        private string farbe;
        public int Baujahr
        {
            get
            {
                return baujahr;
            }
            set
            {
                if(value >= 1863 && value <= System.DateTime.Now.Year)
                {
                    baujahr = value;
                }
                else
                {
                    Console.WriteLine("Ungültiges Baujahr!");
                }
            }
        }
        public string Farbe
        {
            get
            {
                return farbe;
            }
            set
            {
                if(value == "Blau" || value == "Rot" || value == "Gelb" || value == "Grün")
                {
                    farbe = value;
                } else
                {
                    Console.WriteLine("Falsche Farbe!");
                }
            }
        }
        public Auto(int baujahr, string farbe)
        {
            Baujahr = baujahr;
            Farbe = farbe;
        }
    }
}
