using System;

namespace Muziekinstrumenten
{
    public class Muziekinstrument
    {
        private string Naam;

        public Muziekinstrument(string naam)
        {
            Naam = naam;
        }

        /// <summary>
        /// Deze methode zorgt voor het maken van geluid. Echter, een "generiek muziekinstrument", wat voor geluid maakt
        /// zo'n instrument? Geen idee....
        ///
        /// We maken deze methode VIRTUAL: hiermee geef je aan dat een methode in een subclass deze methode opnieuw mag
        /// implementeren en zo wél functionaliteit kan geven aan "Maak Geluid".
        /// </summary>
/*        public virtual void MaakGeluid()
        {
            Console.WriteLine("Ik weet niet wat voor geluid ik moet maken");
            throw new Exception("Foute aanroep");
        }// MaakGeluid*/

        public virtual void MaakGeluid()
        {
            Console.Write("Ik maak geluid:");
        }
    }
}