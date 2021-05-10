using System;
using System.Collections.Generic;
using System.Text;

namespace StaticMethods
{
    /// <summary>
    /// Deze klasse is bruikbaar voor zowel STATIC-methods als object-methodes
    /// </summary>
    class NormalClass
    {
        private string naam;

        public NormalClass(string naam)
        {
            this.naam = naam;
        }

        public void PrintNaam()
        {
            Console.WriteLine(naam);
        }
    }
}
