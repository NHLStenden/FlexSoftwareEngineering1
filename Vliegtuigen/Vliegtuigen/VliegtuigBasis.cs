using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vliegtuigen
{
    class VliegtuigBasis
    {
        private int aantalMotoren;
        protected string aandrijving;

        public VliegtuigBasis(int aantalMotoren, string aandrijving)
        {
            this.aantalMotoren = aantalMotoren;
            this.aandrijving = aandrijving;
        }

        public virtual void Opstijgen()
        {
            if (aantalMotoren > 0)
            {
                Console.WriteLine();
                for (int i = 1; i <= aantalMotoren; i++) Console.WriteLine("Zet motor {0} aan", i );
                Console.WriteLine("Maak vaart");
                Console.WriteLine("Stijg op");
                Console.WriteLine("Vliegen!");
            }
            else
            {
                Console.WriteLine("Hoe dan?");

                Console.WriteLine
            }
                
        }//opstijgen()

        
    }
}
