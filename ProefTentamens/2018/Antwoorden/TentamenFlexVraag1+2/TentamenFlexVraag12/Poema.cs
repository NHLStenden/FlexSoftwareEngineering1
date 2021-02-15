using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TentamenFlex
{
    class Poema : Dier
    {
        public Poema(string geslacht) : base("Poema", geslacht, "Giraffe") { }

        override public string Geluid()
        {
            return "grom";
        }
    }
}
