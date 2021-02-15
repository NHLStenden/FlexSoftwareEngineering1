using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TentamenFlex
{
    class Program
    {
        static void Main(string[] args)
        {
            Dierentuin Emmen = new Dierentuin("Wildlands", "Emmen");
            Dierentuin Gaia  = new Dierentuin("Gaia Zoo", "Maastricht");

            Medewerker bewaker1 = new Medewerker("12", "de Vries", "Klaas");
            Medewerker bewaker2 = new Medewerker("13", "de Jong", "Piet");
            Medewerker bewaker3 = new Medewerker("14", "Ketellapper", "Jan");
            Medewerker bewaker4 = new Medewerker("15", "Haanstra", "Henk");

            Medewerker pz1 = new Medewerker("16", "Rozema", "Klaasje");
            Medewerker pz2 = new Medewerker("17", "Bruinestein", "Anouk");
            Medewerker pz3 = new Medewerker("18", "Einstein", "Albert");
            Medewerker pz4 = new Medewerker("19", "Curie", "Mm");

            Medewerker vk1 = new Medewerker("33", "Mendelejev", "Pjotr");
            Medewerker vk2 = new Medewerker("34", "Alvarez", "Luis");
            Medewerker vk3 = new Medewerker("35", "Ampère", "André-Marie");
            Medewerker vk4 = new Medewerker("36", "Bernoulli", "Daniel ");

            vk1.VeranderSalaris(1000);
            vk2.VeranderSalaris(1001);
            vk3.VeranderSalaris(1002);
            vk4.VeranderSalaris(1003);

            pz1.VeranderSalaris(2001);
            pz2.VeranderSalaris(2002);
            pz3.VeranderSalaris(2003);
            pz4.VeranderSalaris(2004);

            bewaker1.VeranderSalaris(3001);
            bewaker2.VeranderSalaris(3002);
            bewaker3.VeranderSalaris(3003);
            bewaker4.VeranderSalaris(3004);

            vk1.setFunctie("Verkoper");
            vk2.setFunctie("Verkoper");
            vk3.setFunctie("Verkoper");
            vk4.setFunctie("Verkoper");

            bewaker1.setFunctie("Bewaker");
            bewaker2.setFunctie("Bewaker");
            bewaker3.setFunctie("Bewaker");
            bewaker4.setFunctie("Bewaker");
            
            pz1.setFunctie("Personeelszaken");
            pz2.setFunctie("Personeelszaken");
            pz3.setFunctie("Personeelszaken");
            pz4.setFunctie("Personeelszaken");

            Gaia.AddMedewerker(bewaker1);
            Gaia.AddMedewerker(bewaker2);
            Gaia.AddMedewerker(pz1);
            Gaia.AddMedewerker(pz2);
            Gaia.AddMedewerker(vk1);
            Gaia.AddMedewerker(vk2);

            Emmen.AddMedewerker(bewaker3);
            Emmen.AddMedewerker(bewaker4);
            Emmen.AddMedewerker(pz3);
            Emmen.AddMedewerker(pz4);
            Emmen.AddMedewerker(vk3);
            Emmen.AddMedewerker(vk4);

            Dier Leeuw1 = new Leeuw("M");
            Dier Leeuw2 = new Leeuw("F");
            Dier Leeuw3 = new Leeuw("F");
            Dier Leeuw4 = new Leeuw("M");

            Dier Poema1 = new Poema("F");
            Dier Poema2 = new Poema("M");
            Dier Poema3 = new Poema("M");
            Dier Poema4 = new Poema("F");

            Dier Tijger1 = new Tijger("M");
            Dier Tijger2 = new Tijger("F");
            Dier Tijger3 = new Tijger("M");
            Dier Tijger4 = new Tijger("F");
            Dier Tijger5 = new Tijger("F");
            Dier Tijger6 = new Tijger("F");

            Emmen.AddDier(Leeuw1);
            Emmen.AddDier(Leeuw2);
            Emmen.AddDier(Tijger1);
            Emmen.AddDier(Tijger2);
            Emmen.AddDier(Poema1);
            Emmen.AddDier(Poema2);
            Emmen.AddDier(Tijger5);
            Emmen.AddDier(Tijger6);

            Gaia.AddDier(Leeuw3);
            Gaia.AddDier(Leeuw4);
            Gaia.AddDier(Tijger3);
            Gaia.AddDier(Tijger4);
            Gaia.AddDier(Poema3);
            Gaia.AddDier(Poema4);

            Gaia.DierenVoeren();
            Gaia.LuisterNaarDieren();

            Emmen.DierenVoeren();
            Emmen.LuisterNaarDieren();
                       
            float totaalGaia = Gaia.BetaalSalarissen();
            Console.WriteLine("Totaal salaris Gaia: {0}", totaalGaia);
            Console.WriteLine("Gemiddeld salaris Gaia: {0}", totaalGaia / Gaia.AantalMedewerkers());

            Gaia.MaakReclame("Het park bestaat 10 jaar!");

            float totaalEmmen = Emmen.BetaalSalarissen();
            Console.WriteLine("Totaal salaris Emmen : {0}", totaalEmmen);
            Console.WriteLine("Gemiddeld salaris Emmen: {0}", totaalEmmen / Emmen.AantalMedewerkers());
            Emmen.MaakReclame("Het park is helemaal vernieuwd");

            Console.ReadLine();
        }
    }
}
