using System;
using System.Reflection.Metadata.Ecma335;

namespace Polymorfisme01
{
    public class Laptop : Computer
    {
        private bool KlepIsOpen;

        public Laptop()
        {
            KlepIsOpen = false;
            ProcessingPower = 9;
        }

        public override bool Opstarten()
        {
            bool result = false;
            
            Console.WriteLine("Laptop: Ik doe de klep open");
            if (KlepIsOpen)
            {
                result =  base.Opstarten();    
            }
            return result;
        }

        public void DoeKlepOpen()
        {
            this.KlepIsOpen = true;
        }
    }
}