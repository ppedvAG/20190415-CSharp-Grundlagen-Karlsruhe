using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Grundlagen
{
    interface ITier
    {
        int AnzahlBeine { get; set; }
        void Laufen();
    }
}
