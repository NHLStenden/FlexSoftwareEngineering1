using System;
using System.Collections.Generic;
using System.Text;

namespace Gebouwen
{
    class Huurwoning : Gebouw
    {
        string woningbouwvereniging;
        string bewoner;

        public Huurwoning(string woningbouwvereniging, string plaatsnaam, string straatnaam, string huisnummer, string postcode) 
            : base(plaatsnaam, straatnaam, huisnummer, postcode)
        {
            this.woningbouwvereniging = woningbouwvereniging;
        }

        public void setBewoner(string bewoner)
        {
            this.bewoner = bewoner;
        }
        public override void Bewoners()
        {
            string result = this.woningbouwvereniging + "\n(" + this.bewoner + ")\n" + this.BriefAdres();
            Console.WriteLine(result);
        }
    }

}
