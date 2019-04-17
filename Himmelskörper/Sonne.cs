using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Himmelskörper
{
    class Sonne: Himmelskörper
    {
        public override void WerBinIch()
        {
            Console.WriteLine("Ich bin eine Sonne");
        }
        public new void WieVieleBinIch()
        {
            Console.WriteLine("Ich bin eine.");
        }
    }
}
