using System;
using System.Collections.Generic;
using System.Text;

namespace Vormen
{
    class Tekening
    {
        List<Vorm> vormen;

        public Tekening()
        {
            this.vormen = new List<Vorm>();
        }

        public Tekening Add(Vorm vorm)
        {
            this.vormen.Add(vorm);
            return this;
        }

        public void Paint()
        {
            foreach (Vorm vorm in vormen)
            {
                vorm.Paint();
            }
        }
    }
}
