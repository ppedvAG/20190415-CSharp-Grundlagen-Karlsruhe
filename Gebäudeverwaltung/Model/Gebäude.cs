using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Gebäudeverwaltung
{
    public class GebäudeListe
    {
        public Gebäude[] Gebäude { get; set; }
        public List<Gebäude> Gebäude1 { get; set; }
    }
    public class Gebäude
    {
        [XmlElement("Windows")]
        public int Fenster { get; set; }
        public int Türen { get; set; }
        public float Höhe { get; set; }
        public string Name { get; set; }
        public bool IstNeu { get; set; }
        public string Architekturstil { get; set; }
        //public Stockwerk[] Stockwerke; 
    }
    /*public class Stockwerk
    {
        public int ZimmerAnzahl { get; set; }
    }*/
}
