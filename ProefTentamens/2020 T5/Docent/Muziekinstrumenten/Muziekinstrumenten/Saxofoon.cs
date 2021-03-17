using System;

namespace Muziekinstrumenten
{
    class Saxofoon : Blaasinstrument
    {
        string type;
        public Saxofoon(string naam, string type) : base(naam, "koper")
        {
            this.type = type;
        }

        public override void Maakgeluid()
        {
            base.Maakgeluid();
            Console.WriteLine("toet {0}", this.type);
        }
    }
}
