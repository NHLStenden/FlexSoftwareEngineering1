using System;
using System.Collections.Generic;
using System.Text;

namespace Vormen
{
    class Kubus: Driedimensionaal
    {
        int dx, dy, dz;
        public Kubus(int x, int y, string kleur, int dx, int dy, int dz): base(x, y, kleur)
        {
            this.dx = dx;
            this.dy = dy;
            this.dz = dz;
        }

        public override void Paint()
        {
            base.Paint();
            Console.WriteLine("Kubus met zijden ({0},{1},{2})", dx,dy,dz);
        }
    }
}
