using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Grundlagen
{
    class Program
    {
 
        static void Main(string[] args)
        {
            Person p = new Person("Tom", "Müller");
            Console.WriteLine($"Der Vorname der Person lautet: {p.Vorname}.");
            Gärtner g = new Gärtner("Jakob", "Meyer");
            Console.WriteLine($"Der Vorname der Person lautet: {g.Vorname}.");
            Console.WriteLine(g);
            Person person2 = g;
            person2.Laufen();

            var personenListe = new List<Person>();
            personenListe.Add(g);
            personenListe.Add(p);
            personenListe.Add(person2);

            var gärtnerListe = new List<Gärtner>();
            gärtnerListe.Add(g);

            foreach(var item in personenListe)
            {
                item.Laufen();

                //Wir müssen nur einmal auf item zugreifen
                Gärtner gärtner = item as Gärtner;
                if(gärtner != null)
                {
                    gärtner.Gießen();
                }
                //Bis C# 7.0 hier müssen wir zwei mal auf item zugreifen
                if(item is Gärtner)
                {
                    
                    Gärtner gärtner1 = (Gärtner)item;
                    gärtner1.Gießen();
                }
                //Ab C# 7.0
                if(item is Gärtner gärtner2)
                {
                    gärtner2.Gießen();
                }
            }

            foreach(var item in gärtnerListe)
            {
                item.Gießen();
            }

            Console.ReadKey();
        }
    }
}
