using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vliegtuigen
{
    class Program
    {
        static int KlasseVariabele;

        static void Main(string[] args)
        {

            KlasseVariabele = 0;

            List<VliegtuigBasis> vliegapparaten = new List<VliegtuigBasis>();

            VliegtuigBasis plane1 = new VliegtuigBasis(1, "Propellor");
            VliegtuigBasis plane2 = new VliegtuigBasis(2, "Straal");

            vliegapparaten.Add(plane1);
            vliegapparaten.Add(plane2);

            Drone.IkDoeIets();

            Drone drone1 = new Drone();
            Drone.IkDoeIets();

            Drone drone2 = new Drone();
            Drone.IkDoeIets();

            vliegapparaten.Add(drone1);
            vliegapparaten.Add(drone2);

            Militair mil1 = new Militair("Atoombom", 12, "Straal");
            Militair mil2 = new Militair("Sidewinders", 2, "Straal");
            vliegapparaten.Add(mil1);
            vliegapparaten.Add(mil2);

            Zweefvliegtuig float1 = new Zweefvliegtuig();
            Zweefvliegtuig float2 = new Zweefvliegtuig();

            vliegapparaten.Add(float1);
            vliegapparaten.Add(float2);

            foreach (var item in vliegapparaten)
            {
                item.Opstijgen();
            }
            /**
            plane1.Opstijgen();
            plane2.Opstijgen();

            drone1.Opstijgen();
            drone2.Opstijgen();

            mil1.Opstijgen();
            mil2.Opstijgen();

            float1.Opstijgen();
            float2.Opstijgen();

    **/
            // wait for enter key
            Console.ReadLine();

            Test();
        }

        static public void Test()
        {
            // doet ook iets
        }
    }
}
