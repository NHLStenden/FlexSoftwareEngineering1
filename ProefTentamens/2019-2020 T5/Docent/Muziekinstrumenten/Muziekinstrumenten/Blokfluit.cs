using System;
using System.Collections.Generic;
using System.Text;

namespace Muziekinstrumenten
{
    class Blokfluit : Blaasinstrument
    {
        public Blokfluit(string naam) : base(naam, "hout")
        {
        }

        public override void Maakgeluid()
        {
            base.Maakgeluid();
            Console.WriteLine("tuut");
        }
    }
}
