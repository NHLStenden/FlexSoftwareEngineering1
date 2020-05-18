using System;
using System.Collections.Generic;
using System.Text;

namespace Objecten03
{

    enum Aandrijving
    {
        Electrisch, Diesel, Benzine
    }

    class Auto
    {
        public string Merknaam { get; private set; }
        public string type { get; private set; }
        public Aandrijving aandrijving { get; private set; }

        public Auto(string merknaam, string type, Aandrijving aandrijving)
        {
            Merknaam = merknaam;
            this.type = type;
            this.aandrijving = aandrijving;
        }

    }
}
