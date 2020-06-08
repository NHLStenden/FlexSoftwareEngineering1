using System;

namespace Polymorfisme01
{
    public class Desktop : Computer
    {
        public Desktop()
        {
            ProcessingPower = 10;
        }

        public override bool Opstarten()
        {
            Console.WriteLine("Desktop:: Druk op de knop en de rest gaat vanzelf");
            return true;
        }
    }
}