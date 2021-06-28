using System;
using System.Collections.Generic;
using System.Text;

namespace Gebouwen
{
    class Gebouw
    {
        string plaatsnaam;
        string straatnaam;
        string huisnummer;
        string postcode;

        public Gebouw(string plaatsnaam, string straatnaam, string huisnummer, string postcode)
        {
            this.plaatsnaam = plaatsnaam;
            this.straatnaam = straatnaam;
            this.huisnummer = huisnummer;
            this.postcode = postcode;
        }

        public string BriefAdres()
        {
            return this.straatnaam + " " + this.huisnummer + "\n" + this.postcode + " " + this.plaatsnaam.ToUpper();
        }

        public virtual void Bewoners()
        {
            throw new Exception("Geen bewoners bij deze klasse");
        }
    }
}
