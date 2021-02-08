using System;
using System.Collections.Generic;
using System.Text;

namespace Vervoersmiddelen
{
    class Fiets : Vervoersmiddel
    {
        // : base() roept de constructor aan van de bovenliggende klasse
        public Fiets(string kleur): base(2, kleur)
        {
            // wat gebeurt hier: de programmeur die een fiets wil maken
            // moet nog wel een kleur opgeven, maar het aantal wielen
            // staat vast op 2 en wordt via de BASE()-aanroep meteen 
            // meegegeven.
            // de programmeur die deze klasse gebruikt kan dus niet
            // meer het aantal wielen beinvloeden. 
        }

        public void OpZadelGaanZitten()
        {

        }

        // TODO: Implementeren van de functies SnelheidPlus en SnelheidMin
    }
}
