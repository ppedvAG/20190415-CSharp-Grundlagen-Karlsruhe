using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Grundlagen
{
    public class Person
    {
        public string Vorname { get; set; }
        public string Name { get; set; }

        public Person(string vorname, string name)
        {
            Vorname = vorname;
            Name = name;
        }
        public void Laufen()
        {
            Console.WriteLine("Ich bin 3 Meter gelaufen");
        }
    }
}
