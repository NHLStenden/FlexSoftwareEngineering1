using System;
using System.Collections.Generic;
using System.Text;

namespace Vormen
{
    class Cirkel : Ellipsvormig
    {
        public Cirkel(int x, int y, string kleur, int straal): base(x, y, kleur, straal, straal)
        {
        }

    }
}
