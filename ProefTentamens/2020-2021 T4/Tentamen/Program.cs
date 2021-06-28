using System;

namespace Gebouwen
{
    class Program
    {
        static void Main(string[] args)
        {
            Woonwijk LeeuwardenNoord = new Woonwijk("Leeuwarden Noord");
            Koopwoning k1 = new Koopwoning("Leeuwarden", "Brandemeer", "1a", "8918 TH");
            Koopwoning k2 = new Koopwoning("Leeuwarden", "Brandemeer", "2", "8918 TH");
            Koopwoning k3 = new Koopwoning("Leeuwarden", "Brandemeer", "3", "8918 TH");

            k1.setEigenaar("Fam. Jansen");
            k2.setEigenaar("Fam. de Vries");
            k3.setEigenaar("Fam. Chorizo");

            LeeuwardenNoord.AddGebouw(k1).AddGebouw(k2).AddGebouw(k3);

            Huurwoning h1 = new Huurwoning("Elkien","Leeuwarden", "De Jokse", "1", "8918 GL" );
            Huurwoning h2 = new Huurwoning("Elkien","Leeuwarden", "De Jokse", "3", "8918 GL" );
            Huurwoning h3 = new Huurwoning("Elkien","Leeuwarden", "De Jokse", "5", "8918 GL" );
            Huurwoning h4 = new Huurwoning("Elkien","Leeuwarden", "De Jokse", "7", "8918 GL" );

            h1.setBewoner("Caligula");
            h2.setBewoner("D. Frankenstein");
            h3.setBewoner("J. Caesar");
            h4.setBewoner("Herculus");

            LeeuwardenNoord.AddGebouw(h1).AddGebouw(h2).AddGebouw(h3).AddGebouw(h4);

            Kantoorpand b1 = new Kantoorpand("Leeuwarden", "Bilgaardpassage", "1", "8918 HT");
            Kantoorpand b2 = new Kantoorpand("Leeuwarden", "Bilgaardpassage", "2", "8918 HT");
            Kantoorpand b3 = new Kantoorpand("Leeuwarden", "Bilgaardpassage", "3", "8918 HT");
            Kantoorpand b4 = new Kantoorpand("Leeuwarden", "Bilgaardpassage", "4", "8918 HT");

            b1.AddBedrijf("HEMA");
            b2.AddBedrijf("Snackbar de warme hap").AddBedrijf("Action").AddBedrijf("Dierenzaak Petsplace");
            b3.AddBedrijf("Albert Heijn");
            b4.AddBedrijf("Bakkerij Janssensz");

            LeeuwardenNoord.AddGebouw(b1).AddGebouw(b2).AddGebouw(b3).AddGebouw(b4);

            LeeuwardenNoord.GenereerBrieven();

        }
    }
}
