using System;
using System.Collections.Generic;
using System.Text;

namespace Muziekinstrumenten
{
    class Blaasinstrument : Muziekinstrument
    {
        string materiaal;

        /* Deze constructor stond niet in het tentamen vermeld */
        public Blaasinstrument(string naam, string materiaal): base(naam)
        {
            this.materiaal = materiaal;
        }
    }
}
