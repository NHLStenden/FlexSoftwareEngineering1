using System;
using System.Collections.Generic;
using System.Text;

namespace Muziekinstrumenten
{
    class Orkest
    {
        List<Muziekinstrument> instrumenten;

        public Orkest()
        {
            this.instrumenten = new List<Muziekinstrument>();
        }

        public void MaakMuziek() {
            foreach (Muziekinstrument instrument in this.instrumenten)
            {
                instrument.Maakgeluid();
            }
        }

        public  void AddInstrument(Muziekinstrument instrument)
        {
            this.instrumenten.Add(instrument);
        }

    }
}
