using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Muziekinstrumenten
{
    class Toetsinstrumenten : Muziekinstrument
    {
        int aantalToetsen;
        public Toetsinstrumenten(string naam, int aantalToetsen): base(naam)
        {
            this.aantalToetsen = aantalToetsen;
        }

    }
}
