using System;
using System.Collections.Generic;
using System.Text;

namespace Muziekinstrumenten
{
    class Synthesizer : Toetsinstrumenten
    {
        List<string> Geluiden;
        public Synthesizer(string naam) : base(naam, 64)
        {
            this.Geluiden = new List<string>();
        }

        public override void Maakgeluid()
        {
            base.Maakgeluid();
            foreach (string geluid in this.Geluiden)
            {
                Console.Write("{0} ", geluid);
            }
            Console.WriteLine();
        }

        public void AddGeluid(string geluid)
        {
            this.Geluiden.Add(geluid);
        }
    }
}
