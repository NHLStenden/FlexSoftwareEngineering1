using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TentamenFlex
{
    class Medewerker
    {
        private string achternaam;
        private string voornaam;
        private string personeelsnr;
        private float salaris;
        private string functie;

        public Medewerker(string personeelsNr, string achternaam, string voornaam)
        {
            this.personeelsnr = personeelsNr;
            this.voornaam = voornaam;
            this.achternaam = achternaam;
            this.salaris = 0;
            this.functie = "";
        }

        public void VeranderSalaris(float nieuwSalaris)
        {
            salaris = nieuwSalaris;
        }

        public string VolledigeNaam() => voornaam + " " + achternaam;

        public void setFunctie(string functie)
        {
            this.functie = functie;
        }

        public string getFunctie() => this.functie;

        public float getSalaris() => this.salaris;
    }
}
