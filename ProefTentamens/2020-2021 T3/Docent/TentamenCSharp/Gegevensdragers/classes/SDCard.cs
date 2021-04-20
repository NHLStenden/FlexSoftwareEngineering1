using System;

namespace Gegevensdragers.classes
{
    public class SDCard: Gegevensdrager
    {
        private string format;
        
        public SDCard(string naam, string capaciteit, string format) : base(naam, capaciteit, true)
        {
            this.format = format;
        }
        
        public override void report()
        {
            base.report();
            Console.WriteLine("- Formaat: {0}", format);
        }
        
    }
}