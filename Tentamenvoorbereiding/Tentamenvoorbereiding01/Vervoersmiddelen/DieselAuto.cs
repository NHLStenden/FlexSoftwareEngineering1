using System;
using System.Collections.Generic;
using System.Text;

namespace Vervoersmiddelen
{
    class DieselAuto :  Auto
    {
        string brandstof;
        public DieselAuto(string kleur): base(AantalDeurenEnum.vier, kleur)  // deze roept dus de constructor aan de van de klasse AUTO! 
        {
            brandstof = "diesel";
        }

        public override int SnelheidPlus(int delta)
        {
            Console.WriteLine("Heeeeel langzaam......"); // deze roept dus de "SnelheidPlus"-methode van de klasse AUTO aan en NIET rechtstreeks die van VERVOERSMIDDEL!
            return base.SnelheidPlus(delta);
        }
    }
}
