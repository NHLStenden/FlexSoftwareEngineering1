using System.Net.Mime;

namespace Gegevensdragers.classes
{
    public class CompactDisc: Gegevensdrager
    {
        private string ContentType; /* audio or CD ROM */
        
        public CompactDisc(string naam, string contentType): base(naam, "700MB", true)
        {
            this.ContentType = contentType;
        }

        public override void report()
        {
            base.report();
        }
    }
}