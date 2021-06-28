using System;
using System.Collections.Generic;
using System.Text;

namespace Gebouwen
{
    class Woonwijk
    {
        List<Gebouw> gebouwen;
        string naam;

        public Woonwijk(string naam)
        {
            this.naam = naam;
            this.gebouwen = new List<Gebouw>();
        }

        public Woonwijk AddGebouw(Gebouw gebouw)
        {
            this.gebouwen.Add(gebouw);
            return this;
        }

        public void GenereerBrieven()
        {
            foreach (Gebouw gebouw in this.gebouwen)
            {
                gebouw.Bewoners();
                Console.WriteLine("----------------------------");
            }
        }
    }
}
