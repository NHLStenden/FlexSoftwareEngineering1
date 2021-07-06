using System;
using System.Collections.Generic;
using System.Text;

namespace Vormen
{
    class Driedimensionaal : Vorm
    {
        public Driedimensionaal(int x, int y, string kleur): base(x, y, kleur) { }

        public override void Paint()
        {
            base.Paint();
            Console.Write("3d:");
        }
    }
}
