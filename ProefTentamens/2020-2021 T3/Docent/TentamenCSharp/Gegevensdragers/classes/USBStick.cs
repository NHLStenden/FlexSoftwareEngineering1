using System;

namespace Gegevensdragers.classes
{
    public class USBStick: Gegevensdrager
    {
        private bool isEncrypted;
        
        public USBStick(string naam, string capaciteit, bool isEncrypted) : base(naam, capaciteit, true)
        {
            this.isEncrypted = isEncrypted;
        }
        
        public override void report()
        {
            base.report();
            if (isEncrypted)
            {
                Console.WriteLine("- ! Encrypted");                
            }
            
        }
        
    }
}