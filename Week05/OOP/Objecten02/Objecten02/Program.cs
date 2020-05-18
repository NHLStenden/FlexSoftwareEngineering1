using System;

namespace Objecten02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hier maken we een nieuwe bar aan. We geven wat informatie mee aan de Constructor zoals het materiaal en afmetingen.
            Festivalbar drinks5a = new Festivalbar("Mahonie", 3, 5, 10);

            // We kijken eens of de bar standaard geopend is. We gebruiken hier een Methode die een tekst teruggeeft. 
            // Als we hiervoor een property zouden gebruiken zouden we TRUE of FALSE terugkrijgen; deze methode geeft ons een handige tekst.
            // Dat kan ook met een property overigens, maar vereist wat andere syntax in de klasse. 
            Console.WriteLine("Status =  {0} ", drinks5a.Status());
            
            drinks5a.Open();
            Console.WriteLine("Status =  {0} ", drinks5a.Status());
            
            drinks5a.Sluit();
            Console.WriteLine("Status =  {0} ", drinks5a.Status());

            // Roep de method 'NieuweKlant' aan om de variabele 'ZitplaatsenBezet' te veranderen.
            drinks5a.NieuweKlant();
            drinks5a.NieuweKlant();
            drinks5a.NieuweKlant();
            drinks5a.NieuweKlant();
            drinks5a.NieuweKlant();
            drinks5a.NieuweKlant();

            // let op de syntax: er wordt hier een eigenschap opgevraagd, en geen methode aangeroepen
            // om het aantal bezette zitplaatsen op te vragen
            Console.WriteLine("Aantal klanten  = {0}", drinks5a.ZitplaatsenBezet);

            // we roepen hier veel te vaak de methode 'KlantVertrekt' aan, maar dat is niet erg
            // omdat de methode veilig is en eerst controleert of er geen negatief aantal klanten ontstaat.
            drinks5a.KlantVertrekt();
            drinks5a.KlantVertrekt();
            drinks5a.KlantVertrekt();
            drinks5a.KlantVertrekt();
            drinks5a.KlantVertrekt();
            drinks5a.KlantVertrekt();
            drinks5a.KlantVertrekt();
            drinks5a.KlantVertrekt();
            drinks5a.KlantVertrekt();
            drinks5a.KlantVertrekt();
            drinks5a.KlantVertrekt();
            drinks5a.KlantVertrekt();

            Console.WriteLine("Aantal klanten  = {0}", drinks5a.ZitplaatsenBezet);

        }
    }
}
