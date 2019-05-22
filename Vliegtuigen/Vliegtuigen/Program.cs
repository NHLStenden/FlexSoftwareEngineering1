using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vliegtuigen
{
    class Program
    {
        static void Main(string[] args)
        {
            VliegtuigBasis plane1 = new VliegtuigBasis(1, "Propellor");
            VliegtuigBasis plane2 = new VliegtuigBasis(2, "Straal");

            Drone drone1 = new Drone();
            Drone drone2 = new Drone();

            Militair mil1 = new Militair("Atoombom", 12, "Straal");
            Militair mil2 = new Militair("Sidewinders", 2, "Straal");

            Zweefvliegtuig float1 = new Zweefvliegtuig();
            Zweefvliegtuig float2 = new Zweefvliegtuig();

            plane1.Opstijgen();
            plane2.Opstijgen();

            drone1.Opstijgen();
            drone2.Opstijgen();

            mil1.Opstijgen();
            mil2.Opstijgen();

            float1.Opstijgen();
            float2.Opstijgen();

            // wait for enter key
            Console.ReadLine();
        }
    }
}
