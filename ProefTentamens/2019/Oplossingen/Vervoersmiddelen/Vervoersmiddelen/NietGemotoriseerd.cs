using System;

namespace Vervoersmiddelen
{
    public class NietGemotoriseerd : Vervoersmiddel
    {
        private string Aandrijving;
        
        public NietGemotoriseerd(string aandrijving, string naam, int aantalWielen) : base(naam, aantalWielen)
        {
            this.Aandrijving = aandrijving;
        }

        public string GetAandrijving() => this.Aandrijving;

        public override void Print()
        {
            Console.WriteLine("{0}", this.Aandrijving);
        }

    }
}