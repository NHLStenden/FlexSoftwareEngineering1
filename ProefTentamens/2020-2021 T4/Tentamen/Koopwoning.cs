using System;
using System.Collections.Generic;
using System.Text;

namespace Gebouwen
{
    class Koopwoning : Gebouw
    {
        string eigenaar;
        public Koopwoning(string plaatsnaam, string straatnaam, string huisnummer, string postcode) : base(plaatsnaam, straatnaam, huisnummer, postcode)
        {

        }

        public override void Bewoners()
        {
            string result = this.eigenaar + "\n" + this.BriefAdres();
            Console.WriteLine(result);
        }

        public void setEigenaar(string eigenaar)
        {
            this.eigenaar = eigenaar;
        }
    }
}
