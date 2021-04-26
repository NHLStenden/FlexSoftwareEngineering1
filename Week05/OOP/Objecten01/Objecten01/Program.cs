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
            public void xyz() { Console.WriteLine("help"); }
            public void print() { Console.WriteLine("Hallo {0} {1}, je bent {2} jaar oud\nKleur haar = {3}", naam, achternaam, leeftijd, haarkleur);  }
        }

        struct WerkendPersoon
        {
            public string naam;
            public string achternaam;
            public int leeftijd; 
            public string werkgever;
            public string functie;

            public void print() {
                Console.WriteLine("Hallo {0} {1}, je bent {2} jaar oud", naam, achternaam, leeftijd);
                Console.WriteLine("Werkt bij {0} als {1}", werkgever, functie); 
            }
        }

        struct Student
        {
            public string naam;
            public string achternaam;
            public int leeftijd; 
            public string studie;
            public string instelling;
            public void print() {
                Console.WriteLine("Hallo {0} {1}, je bent {2} jaar oud", naam, achternaam, leeftijd);
                Console.WriteLine("Studeert bij {0} opleiding {1}", instelling, studie);  
            }
        }

        struct WerkendeStudent
        {
            public string naam;
            public string achternaam;
            public int leeftijd;
            public string studie;
            public string instelling;
            public string werkgever;
            public string functie;
            public bool deeltijd;
            public void print()
            {
                Console.WriteLine("Hallo {0} {1}, je bent {2} jaar oud", naam, achternaam, leeftijd);
                Console.WriteLine("Werkt bij {0} als {1}", werkgever, functie);
                Console.WriteLine("Studeert in {2} bij {0} opleiding {1}", instelling, studie, deeltijd ? "deeltijd" : "voltijd");
            }
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
            Console.WriteLine("---------------------------------------------------------------------------------------");

            // nieuwe manier: maak een struct aan met alle variabelen samengepakt in één variabele
            // je zou die ingepakte variabelen ook 'eigenschappen van het persoon'  kunnen noemen
            Persoon martin;
            // vul de waarden van de eigenschappen in. hiervoor gebruiken we de punt-notatie:
            // variabele.eigenschap
            martin.naam = "Martin";
            martin.achternaam = "Molema";
            martin.leeftijd = 49;
            martin.haarkleur = "grijs";

            // roep de functie aan en geef in één keer makkelijk alle informatie mee.
            // als er nu een eigenschap veranderd hoef ik tenminste niet de parameterlijst aan te passen ('signature')
            PersoonAfdrukkenStructuur(martin);
            Console.WriteLine("---------------------------------------------------------------------------------------");

            // of nog handiger: met een functie die bij de data hoort
            martin.print();

            // we gaan nu een persoon met een baan opvoeren
            WerkendPersoon employee1;
            employee1.naam = "Martin";
            employee1.achternaam = "Molema";
            employee1.leeftijd = 49;
            employee1.functie = "Docent";
            employee1.werkgever = "NHL Stenden Hogeschool";

            Console.WriteLine("---------------------------------------------------------------------------------------");
            employee1.print();

            // we gaan nu een student maken
            Student studentje;
            studentje.naam = "Martin";
            studentje.achternaam = "Molema";
            studentje.leeftijd = 49;
            studentje.studie = "Master Serious Gaming";
            studentje.instelling = "NHL Stenden Hogeschool";

            Console.WriteLine("---------------------------------------------------------------------------------------");
            studentje.print();

            
            // we gaan nu een werkstudent maken
            WerkendeStudent werkstudent;
            werkstudent.naam = "Martin";
            werkstudent.achternaam = "Molema";
            werkstudent.leeftijd = 49;
            werkstudent.studie = "Master Serious Gaming";
            werkstudent.instelling = "NHL Stenden Hogeschool";
            werkstudent.functie = "Docent";
            werkstudent.werkgever = "NHL Stenden Hogeschool";
            werkstudent.deeltijd = true;

            Console.WriteLine("---------------------------------------------------------------------------------------");
            werkstudent.print();
        }

        static void PersoonAfdrukken(string naam, string achternaam, int leeftijd, string haarkleur)
        {
            Console.WriteLine("Hallo {0} {1}, je bent {2} jaar oud\nKleur haar = {3}", naam, achternaam, leeftijd, haarkleur);
        }

        static void PersoonAfdrukkenStructuur(Persoon p)
        {
            // we gebruiken hier weer de punt-notatie om de eigenschappen op te halen uit de samengestelde variabele ('struct').
            Console.WriteLine("Hallo {0} {1}, je bent {2} jaar oud\nKleur haar = {3}", p.naam, p.achternaam, p.leeftijd, p.haarkleur);
            p.xyz();
        }
    }
}
