using System;
using System.Collections.Generic;
using System.Text;

namespace Objecten02
{
    class Festivalbar
    {
        // een nieuwe klasse met een aantal eigenschappen zoals afmetingen, materiaal en informatie
        // over zitplaatsen (beschikbaar en bezet)

        private string Materiaal;
        private int Hoogte, Breedte, Lengte;
        private int Zitplaatsen;
        public int ZitplaatsenBezet {       
            // een 'field' dat leesbaar is ('get') door gebruikers van deze klasse
            // maar alleen methodes in de klasse zelf mogen de eigenschap wijzigen ('private set')
            get;    
            private set;
        }


        /// <summary>
        /// Geopend == true ==> de bar is geopend!
        /// </summary>
        private bool geopend;

        /// <summary>
        /// Constructor : deze maakt op basis van een beperkt aantal gegevens de bar.
        /// op basis van de opgegeven parameters wordt het object (=instantie van een klasse) verder ingevuld. 
        /// </summary>
        /// <param name="materiaal"></param>
        /// <param name="hoogte"></param>
        /// <param name="breedte"></param>
        /// <param name="lengte"></param>
        public Festivalbar(string materiaal, int hoogte, int breedte, int lengte)
        {
            Materiaal = materiaal;
            Hoogte = hoogte;
            Breedte = breedte;
            Lengte = lengte;

            Zitplaatsen = (int) Math.Floor ((float)lengte / 1.5f); //Corona proof seating!
            ZitplaatsenBezet = 0;

            // het verdient de voorkeur om methodes aan te roepen als je eigenschappen van je klasse aanpast. 
            // zo bescherm je jezelf ook tegen fouten! Je hebt immers eventuele controles daar al netjes ingebouwd!
            Sluit();
        }

        public string Status()
        {
            // ternaire operator om in één keer de booleaanse waarde om te zetten in een stukje leesbare tekst
            return geopend ? "Geopend" : "Gesloten";
        }

        public void Open() {
            geopend = true;
        }

        public void Sluit()
        {
            geopend = false;
        }

        /// <summary>
        /// Deze method checkt eerst of er nog wel zitplaatsen zijn. zo niet, dan geen verandering in het aantal klanten.
        /// </summary>
        public void NieuweKlant()
        {
            if (ZitplaatsenBezet < Zitplaatsen) ZitplaatsenBezet++;
        }

        /// <summary>
        /// Deze method checkt wel of er niet meer klanten het pand verlaten dan dat er binnen gekomen zijn.
        /// </summary>
        public void KlantVertrekt()
        {
            if (ZitplaatsenBezet >= 1) ZitplaatsenBezet--;
        }

    }
}
