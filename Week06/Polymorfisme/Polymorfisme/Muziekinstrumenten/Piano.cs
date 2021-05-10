using System;
using System.Threading;

namespace Muziekinstrumenten
{
    public class Piano : Muziekinstrument
    {
        public Piano(string naam) : base(naam)
        {
        }

        public override void MaakGeluid()
        {

            Console.WriteLine("Pling pling");
            base.MaakGeluid();
        }
    }
}