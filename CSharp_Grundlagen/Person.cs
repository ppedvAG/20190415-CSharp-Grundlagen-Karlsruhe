using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Grundlagen
{
    class Person
    {
        public string Vorname { get; private set; }
        public string Name { get; private set; }

        public Person(string vorname, string name)
        {
            Vorname = vorname;
            Name = name;
        }

        public void Laufen()
        {
            Console.WriteLine("Ich bin 5 Meter weit gelaufen");
        }
    }
}
