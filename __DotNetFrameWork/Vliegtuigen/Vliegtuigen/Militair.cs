using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vliegtuigen
{
    class Militair : VliegtuigBasis
    {
        private string bewapening;

        public Militair(string Bewapening, 
            int aantalMotoren, 
            string aandrijving) : 
            base(aantalMotoren, aandrijving)
        {
            this.bewapening = Bewapening;

            this.aandrijving = "zoek het uit";

        }
    }
}
