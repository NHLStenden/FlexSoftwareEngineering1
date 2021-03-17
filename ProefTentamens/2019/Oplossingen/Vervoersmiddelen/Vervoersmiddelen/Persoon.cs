using System;
using System.Collections.Generic;

namespace Vervoersmiddelen
{
    public class Persoon
    {
        private String Naam;
        private String BSN;
        private List<Vervoersmiddel> Middelen;

        public Persoon(string naam, string bsn)
        {
            Naam = naam;
            BSN = bsn;
            this.Middelen = new List<Vervoersmiddel>();
        }

        public int AddVervoersmiddel(Vervoersmiddel middel)
        {
            this.Middelen.Add(middel);
            return this.Middelen.Count;
        }

        public void Report()
        {
            int i = 1;

            Console.WriteLine("------------------------------------");
            
            foreach (Vervoersmiddel middel in Middelen)
            {
                Console.Write("{0} : {1}:",i++, middel.GetNaam());
                middel.Print();
/*                if (middel is Gemotoriseerd)
                {
                    Console.WriteLine("brandstof: {0}", (middel as Gemotoriseerd).GetBrandstof());
                }
                if (middel is NietGemotoriseerd)
                {
                    Console.WriteLine("aandrijving");
                }*/
            }

            Console.WriteLine("Totaal {0} vervoersmiddelen", i-1);
            Console.WriteLine("------------------------------------");
        }
    }
}