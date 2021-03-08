using System;

namespace Vervoersmiddelen
{
    public class Gemotoriseerd : Vervoersmiddel
    {
        private string Brandstof;

        public Gemotoriseerd(string brandstof, string naam) : base(naam)
        {
            Brandstof = brandstof;
        }

        public string GetBrandstof() => this.Brandstof;

        public override void Print()
        {
            Console.WriteLine("{0}", Brandstof);
        }
    }
}