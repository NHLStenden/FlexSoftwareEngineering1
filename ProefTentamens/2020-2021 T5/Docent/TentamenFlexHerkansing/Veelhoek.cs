using System;
using System;
using System.Collections.Generic;
using System.Text;

namespace Vormen
{
    class Veelhoek : Vorm
    {
        int[] zijden;

        public Veelhoek(int x, int y, string kleur, int[] zijden): base(x, y, kleur)
        {
            this.zijden = zijden;
        }

        public override void Paint()
        {
            base.Paint();
            Console.WriteLine("Veelhoek met {0} zijden ({1})", zijden.Length, String.Join(',', zijden));
        }
    }
}
