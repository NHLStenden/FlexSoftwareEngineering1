using System;
using System.Collections.Generic;
using System.Text;

namespace Muziekinstrumenten
{
    class AkoestischePiano : Toetsinstrumenten
    {
        public AkoestischePiano(string naam) : base(naam, 64)
        {

        }

        public override void Maakgeluid()
        {
            base.Maakgeluid();
            Console.WriteLine("pling pling");
        }
    }
}
