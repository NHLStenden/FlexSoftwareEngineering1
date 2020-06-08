namespace Drinkgerei01.classes
{
    public class Drinkgerei
    {
        private bool heeft_oor;
        private string soort_drank;
        private int capaciteit; // aantal cc volume 

        public bool HeeftOor
        {
            get => heeft_oor;
            set => heeft_oor = value;
        }

        public string SoortDrank
        {
            get => soort_drank;
            set => soort_drank = value;
        }

        public int Capaciteit
        {
            get => capaciteit;
            set => capaciteit = value;
        }

        protected int _hoeveelheid; // aantal cc volume

        public int Hoeveelheid
        {
            get => _hoeveelheid;
            set => _hoeveelheid = value - 5;
        }

        public Drinkgerei(bool heeftOor, string soortDrank, int capaciteit, int hoeveelheid)
        {
            heeft_oor = heeftOor;
            soort_drank = soortDrank;
            this.capaciteit = capaciteit;
            Hoeveelheid = hoeveelheid;
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