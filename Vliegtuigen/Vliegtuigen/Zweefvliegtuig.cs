using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vliegtuigen
{
    class Zweefvliegtuig : VliegtuigBasis
    {
        public Zweefvliegtuig() : base(0, "thermiek")
        {

        }

        public override void Opstijgen()
        {
            Console.WriteLine();
            base.Opstijgen();
            Console.WriteLine();

            Console.WriteLine("Zoek ander vliegtuig");
            Console.WriteLine("Sluit lier aan");
            Console.WriteLine("Neem plaats en wacht tot je hoog genoeg zit");
            Console.WriteLine("Ontkoppel lier");
            Console.WriteLine("Enjoy the ride (and silence)");
            Console.WriteLine();
        }
    }
}
