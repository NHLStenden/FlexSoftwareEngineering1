using System;
using System.Collections.Generic;
using System.Text;

namespace Muziekinstrumenten
{
    class Muziekinstrument
    {
        string Naam;
        public virtual void Maakgeluid() {
            Console.Write("{0}: ", this.Naam);
        }

        public Muziekinstrument() { }

        public Muziekinstrument(string naam)
        {
            Naam = naam;
        }

        public void SetNaam(string naam)
        {
            this.Naam = naam;
        }

        /* deze stond niet in het tentamen vermeld ! */
        public string Getnaam()
        {
            return this.Naam;
        }
    }
}
