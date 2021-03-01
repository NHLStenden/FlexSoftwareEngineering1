using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TentamenFlex
{
    class Dierentuin
    {
        private string Naam;
        private string Plaats;
        private List<Medewerker> medewerkers;
        private List<Dier> dieren;

        public Dierentuin(string naam, string plaats)
        {
            this.Naam   = naam;
            this.Plaats = plaats;

            // initialiseer de lijsten (dit had ook bij de variabele declaratie gekund).
            medewerkers = new List<Medewerker>();
            dieren      = new List<Dier>();
        }

        public void MaakReclame(string uiting)
        {
            Console.WriteLine("Komt allen naar dierentuin {0} te {1}", Naam, Plaats);
            Console.WriteLine("Met {0} medewerkers maken wij er een onvergetelijke dag van", this.AantalMedewerkers());
            Console.WriteLine("Wij hebben de volgende dieren in onze dierentuin");


            // gebruik een dictionairy: een lijst waarbij je een sleutel (key) en een waarde (value) kunt opslaan
            // de key kun je gebruiken om te zoeken en de waarde op te halen
            Dictionary<string, int> keyValuePairs = new Dictionary<string, int>();

            // doorloop de lijst met dieren
            foreach (var dier in dieren)
            {
                // bepaal de soortnaam
                string soortnaam = dier.getSoortnaam();
                
                // kijk of de soortnaam al in onze dictionairy voorkomt
                if (!keyValuePairs.ContainsKey(soortnaam))
                {
                    // zo niet: voeg deze soort dan toe aan de lijst met de waarde nul
                    keyValuePairs.Add(soortnaam,0);
                }

                // als we hier aankomen weten we zeker dat de soortnaam in de lijst voorkomt.
                // een Dictionairy kun je als Array benaderen met de sleutel/key als index.
                // de gevonden waarde verhogen we met één
                keyValuePairs[soortnaam]++;
            }

            // de dictionairy is nu op orde. tijd om deze te printen naar de console.
            foreach (var keyValuePair in keyValuePairs)
            {
                Console.WriteLine("{0} van soort {1}" , keyValuePair.Value, keyValuePair.Key);
            }

        }

        public float BetaalSalarissen()
        {
            float totaal = 0;
            foreach (var medewerker in medewerkers)
            {
                Console.WriteLine("{0} {1} {2}", medewerker.VolledigeNaam(), medewerker.getFunctie() ,medewerker.getSalaris());
                totaal += medewerker.getSalaris();
            }

            return totaal;

        }

        public void DierenVoeren()
        {
            foreach (Dier dier in dieren)
            {
                dier.GeefEten();
            }
        }

        public int AddMedewerker(Medewerker mdw)
        {
            medewerkers.Add(mdw);

            return this.AantalMedewerkers();
        }


        public int AantalMedewerkers()
        {
            return this.medewerkers.Count();
        }

        public int AddDier(Dier nieuwDier)
        {
            this.dieren.Add(nieuwDier);

            return this.AantalDieren();
        }

        public int AantalDieren()
        {
            return this.dieren.Count();
        }

        public void LuisterNaarDieren()
        {
            foreach (Dier dier in dieren)
            {
                Console.WriteLine(dier.getSoortnaam() + ":"  + dier.Geluid());
            }
        }

    }
}
