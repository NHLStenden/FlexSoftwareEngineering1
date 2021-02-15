using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TentamenFlex
{
    class Dier
    {
        private string geslacht;
        private string soortnaam;
        private string voer;

        public Dier(string soortnaam, string geslacht, string voer)
        {
            this.soortnaam = soortnaam;
            this.geslacht  = geslacht;
            this.voer      = voer;
        }

        virtual public void GeefEten()
        {
            Console.WriteLine("Open hok {0}", getSoortnaam());
            Console.WriteLine("Geef eten:{0}", voer);
            Console.WriteLine("Sluit hok {0}",getSoortnaam());
        }

        public string getSoortnaam()
        {
            return this.soortnaam;
        }

        // door het sleutelwoord 'virtual' toe te voegen mag een subklasse (tijger, poema, leeuw) deze functie ook implementeren.
        virtual public string Geluid()
        {
            return "";
        }
    }
}
