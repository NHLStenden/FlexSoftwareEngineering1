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

        public override int SnelheidPlus(int delta)
        {
            Console.WriteLine("Draai harder met de beentjes");
            return base.SnelheidPlus(delta);
        }

        public override int SnelheidMin(int delta)
        {
            Console.WriteLine("Remmen gaat vanzelf!");
            return base.SnelheidMin(delta);
        }


        public void OpZadelGaanZitten()
        {

        }

        // TODO: Implementeren van de functies SnelheidPlus en SnelheidMin
    }
}
