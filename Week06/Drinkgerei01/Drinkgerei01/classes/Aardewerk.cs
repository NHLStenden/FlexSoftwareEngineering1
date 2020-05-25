namespace Drinkgerei01.classes
{
    public class Aardewerk : Drinkgerei
    {
        private bool heeftGlazuur;
        private string kleur; // bijv. een HTML-kleuraanduiding #feafbe
        private bool nietDoorzichtig;

        public Aardewerk(bool heeftOor, string soortDrank, int capaciteit, int hoeveelheid, bool heeftGlazuur, string kleur, bool nietDoorzichtig) : base(heeftOor, soortDrank, capaciteit, hoeveelheid)
        {
            this.heeftGlazuur = heeftGlazuur;
            this.kleur = kleur;
            this.nietDoorzichtig = nietDoorzichtig;
        }
    }
}