using System;
using System.Collections.Generic;
using System.Text;

namespace Vormen
{
    class Ellipsvormig: Vorm
    {
        int r1, r2;

        public Ellipsvormig(int x, int y, string kleur, int r1, int r2): base( x, y, kleur)
        {
            this.r1 = r1;
            this.r2 = r2;
        }

        public override void Paint()
        {
            base.Paint();
            Console.WriteLine("Ellipse met straal ({0},{1}) ", r1, r2);

        }
    }
}
