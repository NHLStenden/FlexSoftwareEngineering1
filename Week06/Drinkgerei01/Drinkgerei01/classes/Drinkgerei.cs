namespace Drinkgerei01.classes
{
    public class Drinkgerei
    {
        private bool heeft_oor;
        private string soort_drank;
        private int capaciteit; // aantal cc volume 
        private int hoeveelheid; // aantal cc volume

        public Drinkgerei(bool heeftOor, string soortDrank, int capaciteit, int hoeveelheid)
        {
            heeft_oor = heeftOor;
            soort_drank = soortDrank;
            this.capaciteit = capaciteit;
            this.hoeveelheid = hoeveelheid;
        }

        public void Drink()
        {
            
        }

        public void Vullen()
        {
            
        }

        public void BreekOor()
        {
            
        }

        public void Afwassen()
        {
            
        }
    }
}