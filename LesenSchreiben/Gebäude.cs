using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace LesenSchreiben
{
    public partial class Gebäude
    {
        [XmlElement("Windows")]
        public int Fenster { get; set; } = 5;
        public int Türen { get; set; } = 10;
        public float Höhe { get; set; } = 243.20f;
        public string Name { get; set; } = "Komisches Haus";
        public bool IstNeu { get; set; } = true;
        public Stockwerk[] Stockwerke; 
    }
    public class Stockwerk
    {
        public int ZimmerAnzahl { get; set; }
    }
}
