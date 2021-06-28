using System;
using System.Collections.Generic;

namespace Gebouwen
{
    class Kantoorpand : Gebouw
    {
        List<String> bedrijven;

        public Kantoorpand(string plaatsnaam, string straatnaam, string huisnummer, string postcode) : base(plaatsnaam, straatnaam, huisnummer, postcode)
        {
            this.bedrijven = new List<string>();
        }

        public Kantoorpand AddBedrijf(string bedrijfsnaam)
        {
            this.bedrijven.Add(bedrijfsnaam);
            return this;
        }

        public int AantalBedrijven()
        {
            return this.bedrijven.Count;
        }

        public override void Bewoners()
        {
            foreach (string bedrijfsnaam in bedrijven)
            {
                string result = bedrijfsnaam + "\n" + this.BriefAdres();
                Console.WriteLine( result );
            }
        }

    }
}
