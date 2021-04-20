using System;

namespace Gegevensdragers.classes
{
    public class DVD: Gegevensdrager
    {
        
        public DVD(string movie) : base(movie, "4GB", true)
        {
        }
       
    }
}