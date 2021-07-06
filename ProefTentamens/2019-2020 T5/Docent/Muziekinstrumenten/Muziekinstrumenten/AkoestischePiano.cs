using System;
using System.Collections.Generic;
using System.Text;

namespace Muziekinstrumenten
{
    class AkoestischePiano : Toetsinstrumenten
    {
        
        public AkoestischePiano(string naam) : base(naam, 88)
        {

        }

        public override void Maakgeluid()
        {
            // omdat de variabele 'naam' private is in de base-class kunnen we die hier niet gebruiken
            // twee mogelijke oplossingen:
            // 1) gebruik de methode 'maakgeluid' uit de base class om die naam alvast af te drukken
            // 2) gebruik de acces-methode 'GetNaam()' om die variabele-waarde van 'naam' te verkrijgen en alles in 1x af te drukken.
            //base.Maakgeluid();
            //Console.WriteLine("pling pling");
            Console.WriteLine("{0} pling pling", Getnaam());
        }
    }
}
