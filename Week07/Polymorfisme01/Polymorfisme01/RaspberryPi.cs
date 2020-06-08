using System;

namespace Polymorfisme01
{
    public class RaspberryPi : Computer
    {
        public RaspberryPi()
        {
            ProcessingPower = 5;
        }

        public override bool Opstarten()
        {
            Console.WriteLine("RPI: steek de stekker in het stopcontact");

            return (new Random().Next()) > 1;
        }
    }
}