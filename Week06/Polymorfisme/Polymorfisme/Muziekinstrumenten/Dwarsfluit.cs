using System;

namespace Muziekinstrumenten
{
    /// <summary>
    /// Dit is de dwarsfluit klasse en die doet ....
    /// </summary>
    public class Dwarsfluit : Muziekinstrument
    {
        public Dwarsfluit(string naam) : base(naam)
        {
            // lege constructor; geen extra acties of variabelen nodig
        }

        public override void MaakGeluid()
        {
            base.MaakGeluid();
            Console.WriteLine("Fluit fluit");
        }

        public void Poetsen()
        {
            Console.WriteLine("Poets poets - Glim Glim");
        }
        
    }
}