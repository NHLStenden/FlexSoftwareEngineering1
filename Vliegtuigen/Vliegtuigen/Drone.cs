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
        public Drone() : base(1, "straal")
        {

        }//constructor
    }
}
