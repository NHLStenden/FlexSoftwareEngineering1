using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TentamenFlex
{
    class Leeuw : Dier
    {
        public Leeuw(string geslacht) : base("Leeuw", geslacht, "Antilope") { }

        
        override public string Geluid()
        {
            return "nogal harde brul";
        }
    }
}
