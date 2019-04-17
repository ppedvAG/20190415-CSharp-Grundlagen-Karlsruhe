using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesenSchreiben
{
    class Program
    {
        static void Main(string[] args)
        {
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
