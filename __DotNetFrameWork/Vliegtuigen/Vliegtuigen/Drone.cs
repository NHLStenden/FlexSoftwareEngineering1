using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vliegtuigen
{
    /// <summary>
    /// let op : dit is een militaire drone met straal aandrijving en niet dat quadrocopter die je zoon wil.
    /// </summary>
    class Drone : VliegtuigBasis
    {
        static int instantieTeller =0;
        
        public Drone() : base(1, "straal")
        {
            instantieTeller++;

        }//constructor

        static public void IkDoeIets()
        {
            Console.WriteLine("Een statische methode {0}" , instantieTeller);
        }
    }
}
