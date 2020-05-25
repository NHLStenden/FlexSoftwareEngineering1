using System.ComponentModel.DataAnnotations;

namespace Drinkgerei01.classes
{
    public class Glas : Drinkgerei
    {
        private int maxTemperatuur; // graden celcius van de vloeistof
        private bool krasvast;
        private int transparantie; // 0-100% 
        private int dikteMateriaal;  // in millimeter

        public Glas(bool heeftOor, string soortDrank, int capaciteit, int hoeveelheid, int maxTemperatuur, bool krasvast, int transparantie, int dikteMateriaal) : base(heeftOor, soortDrank, capaciteit, hoeveelheid)
        {
            this.maxTemperatuur = maxTemperatuur;
            this.krasvast = krasvast;
            this.transparantie = transparantie;
            this.dikteMateriaal = dikteMateriaal;
        }
    }
}