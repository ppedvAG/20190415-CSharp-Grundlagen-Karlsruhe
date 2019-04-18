using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bitte gib eine Zahl ein:");
            int eingegebeneZahl;

            try
            {
                eingegebeneZahl = int.Parse(Console.ReadLine());
            } catch(FormatException e)
            {
                Console.WriteLine("Eine FormatException wurde abgefangen!");
            } catch(Exception e)
            {
                Console.WriteLine("Eine Exception wurde abgefangen!");
            } catch(OverflowException e)
            {
                Console.WriteLine("Eine OverflowException wurde abgefangen!");
            }

            Console.ReadKey();
        }
    }
}
