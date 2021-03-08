using System;

namespace Vervoersmiddelen
{
    public class Vervoersmiddel
    {
        private String Naam;
        private int AantalWielen;

        public Vervoersmiddel(string naam, int aantalWielen)
        {
            this.Naam = naam;
            AantalWielen = aantalWielen;
        }

        public Vervoersmiddel(string naam)
        {
            this.Naam = naam;
        }

        public string GetNaam() => this.Naam;
        public int GetAantalWielen() => this.AantalWielen;
        
        public virtual void Print(){}
    }
}