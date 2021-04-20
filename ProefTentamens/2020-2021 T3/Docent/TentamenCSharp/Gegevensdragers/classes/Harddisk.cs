using System;
using System.Runtime.Serialization;

namespace Gegevensdragers.classes
{
    public class Harddisk: Gegevensdrager
    {
        string format;
        public Harddisk(string naam, string capaciteit, string format) : base(naam, capaciteit, false)
        {
            this.format = format;
        }
        
        public override void report()
        {
            base.report();
            Console.WriteLine("- {0}\"", format);
        }
    }
}