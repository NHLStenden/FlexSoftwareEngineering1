using System;

namespace Gegevensdragers.classes
{
    public class SolidStateDisk: Gegevensdrager
    {
        private string speed;
        public SolidStateDisk(string naam, string capaciteit, string speed) : base(naam, capaciteit, false)
        {
            this.speed = speed;
        }
        
        public override void report()
        {
            base.report();
            Console.WriteLine("- {0}", speed);
        }
        
    }
}