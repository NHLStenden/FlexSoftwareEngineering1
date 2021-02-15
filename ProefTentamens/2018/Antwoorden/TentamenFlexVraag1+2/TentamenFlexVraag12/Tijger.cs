using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TentamenFlex
{
    class Tijger : Dier
    {
        public Tijger(string geslacht) : base("Tijger", geslacht, "Nijlpaard") { }

        override public string Geluid()
        {
            return "brul";
        }
    }


}
