using System;
using System.Collections.Generic;
using System.Text;

namespace Objecten03
{
    class Garage
    {
        // Deze garage heeft een lijst met autos die ze in bezit hebben.
        // Het is niet toegestaan om zelf autos aan de lijst toe te voegen: hiervoor is een AddCar-methode.
        private List<Auto> Autos;
        // Een handige property die alleen leesbaar is (er is geen 'set'). Deze haalt het aantal autos in de lijst op
        // en geeft dit getal terug (dit is een zogenaamde Lambda-expressie). De pijl ('fat-arrow notation') geeft aan 
        // dat de expressie die er na komt ('Autos.Count') als resultaat teruggegeven moet worden. 
        // dit kan ook met get => {return Autos.Count;}
        public int Count { get => Autos.Count; }

        public Garage() // Default constructor: een constructor zonder parameters
        {
            // hier maken we een lege lijst aan. 
            Autos = new List<Auto>();
        }

        public int AddCar(Auto auto)
        {
            // voeg de opgegeven auto toe aan de lijst en geef het aantal autos terug als resultaat.
            Autos.Add(auto);

            return Autos.Count;
        }

        // dit is een methode die hetzelfde doet als de eigenschap 'Count' bovenin de klasse
        public int NumberOfCars()
        {
            return Autos.Count;
        }

        // een handige methode die een lijstje print van alle autos in de garage.
        public void Report()
        {
            foreach (var auto in Autos)
            {
                Console.WriteLine("- {0} [{1}]  : {2}", auto.Merknaam , auto.type, auto.aandrijving );
            }
        }
    }
}
