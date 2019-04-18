using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace LesenSchreiben
{
    class Program
    {
        static void Main(string[] args)
        {
            Gebäude komischesGebäude = new Gebäude();
            var stockwerk1 = new Stockwerk();
            stockwerk1.ZimmerAnzahl = 10;
            var stockwerk2 = new Stockwerk();
            stockwerk2.ZimmerAnzahl = 4;
            var stockwerk3 = new Stockwerk();
            stockwerk3.ZimmerAnzahl = 99;
            var stockwerk4 = new Stockwerk();
            stockwerk4.ZimmerAnzahl = 30;
            komischesGebäude.Stockwerke = new Stockwerk[]{ stockwerk1, stockwerk2, stockwerk3, stockwerk4};

            Console.WriteLine(JsonConvert.SerializeObject(komischesGebäude));
            Console.ReadKey();
            XmlSerializer xmlSer = new XmlSerializer(typeof(Gebäude));
            TextWriter textWriter = new StreamWriter("Datei.xml");
            xmlSer.Serialize(textWriter, komischesGebäude);
            textWriter.Close();



            using (StreamWriter sw = new StreamWriter("Datei.txt"))
            {
                var emoji = char.ConvertFromUtf32(0x1F610);
                sw.WriteLine("Zeile1\u24B7\u28A9" + emoji);
                sw.WriteLine("Zeile2");
                sw.WriteLine("Zeile3");
            }

            StreamReader sr = new StreamReader("Datei.txt");
            while(!sr.EndOfStream)
            {
                string zeile = sr.ReadLine();
            }
            sr.Close();
        }
    }
}
