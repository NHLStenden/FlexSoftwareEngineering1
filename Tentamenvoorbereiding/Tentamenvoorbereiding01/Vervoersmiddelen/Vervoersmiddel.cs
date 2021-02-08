using System;
using System.Collections.Generic;
using System.Text;

namespace Vervoersmiddelen
{
    class Vervoersmiddel
    {
        private string kleur;
        private string fabrikant;
        private int snelheid;
        /// <summary>Het aantal wielen</summary>
        private int aantalWielen;

        /// <summary>
        /// Maak een nieuw vervoersmiddel
        /// </summary>
        /// <param name="wielen">Het aantal wielen</param>
        /// <param name="kleur">Kleur van de fiets</param>
        public Vervoersmiddel(int wielen, string kleur)
        {
            this.aantalWielen = wielen;
            this.snelheid = 0;
            this.fabrikant = "";
            this.kleur = kleur;
        }

        public void Berijden()
        {
            Console.WriteLine("We gaan rijden");
        }

        public int SnelheidPlus(int delta)
        {
            snelheid = snelheid + delta;
            return snelheid;
        }

        public int SnelheidMin(int delta)
        {
            snelheid = snelheid - delta;
            return snelheid;
        }

        public int watIsHetAantalWielen()
        {
            return this.aantalWielen;
        }
    }
}
