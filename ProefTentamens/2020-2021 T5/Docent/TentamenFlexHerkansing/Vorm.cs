using System;
using System.Collections.Generic;
using System.Text;

namespace Vormen
{
    class Vorm
    {
        int x, y;
        string kleur;

        public Vorm(int x, int y, string kleur)
        {
            this.x = x;
            this.y = y;
            this.kleur = kleur;
        }

        public virtual void Paint()
        {
            Console.Write("({0},{1}) - {2} :", x,y, kleur);
        }
    }
}
