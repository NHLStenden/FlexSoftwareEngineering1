using System;
using System.Collections.Generic;
using System.Text;

namespace Vormen
{
    class Vierkant : Veelhoek
    {
        public Vierkant(int x, int y, string kleur, int zijde) : base(x, y, kleur, new int[] { zijde, zijde, zijde, zijde})
        {
        }

    }
}
