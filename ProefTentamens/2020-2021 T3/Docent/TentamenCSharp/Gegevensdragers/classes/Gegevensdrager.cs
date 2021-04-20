using System;

namespace Gegevensdragers.classes
{
    public class Gegevensdrager
    {
        private string Capaciteit;
        private bool IsPortable;
        private string Naam;

        public Gegevensdrager(string naam, string capaciteit, bool isPortable)
        {
            Naam = naam;
            Capaciteit = capaciteit;
            IsPortable = isPortable;
        }

        public virtual void report()
        {
            Console.WriteLine("[{0}] {1} = {2} {3}", this.GetType().Name, Naam, Capaciteit, IsPortable ? "(portable)": "");
        }
    }
}