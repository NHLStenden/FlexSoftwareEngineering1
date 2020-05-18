using System;

namespace Objecten01
{
    class Program
    {
        // Met deze 'struct' kunnen we eenvoudig een aantal variabelen samennemen 
        struct Persoon
        {
            public string naam;
            public string achternaam;
            public int leeftijd;
            public string haarkleur;
        }
        static void Main(string[] args)
        {

            // oude manier: allemaal losse variabelen
            string naam, achternaam, haarkleur;
            int leeftijd;

            naam = "Martin";
            achternaam = "Molema";
            leeftijd = 49;
            haarkleur = "grijs";

            // bij de aanroep dus alle variabelen meegeven. onhandig en slecht onderhoudbaar
            PersoonAfdrukken(naam, achternaam, leeftijd, haarkleur);

            // nieuwe manier: maak een struct aan met alle variabelen samengepakt in één variabele
            // je zou die ingepakte variabelen ook 'eigenschappen van het persoon'  kunnen noemen
            Persoon martin = new Persoon();
            // vul de waarden van de eigenschappen in. hiervoor gebruiken we de punt-notatie:
            // variabele.eigenschap
            martin.naam = "Martin";
            martin.achternaam = "Molema";
            martin.leeftijd = 49;
            martin.haarkleur = "grijs";

            // roep de functie aan en geef in één keer makkelijk alle informatie mee.
            // als er nu een eigenschap veranderd hoef ik tenminste niet de parameterlijst aan te passen ('signature')
            PersoonAfdrukkenStructuur(martin);
        }

        static void PersoonAfdrukken(string naam, string achternaam, int leeftijd, string haarkleur)
        {
            Console.WriteLine("Hallo {0} {1}, je bent {2} jaar oud\nKleur haar = {3}", naam, achternaam, leeftijd, haarkleur);
        }

        static void PersoonAfdrukkenStructuur(Persoon p)
        {
            // we gebruiken hier weer de punt-notatie om de eigenschappen op te halen uit de samengestelde variabele ('struct').
            Console.WriteLine("Hallo {0} {1}, je bent {2} jaar oud\nKleur haar = {3}", p.naam, p.achternaam, p.leeftijd, p.haarkleur);
        }
    }
}
