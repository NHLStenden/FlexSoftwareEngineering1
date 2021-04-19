using System;

namespace Recursie
{
    class Program
    {
        static void Main(string[] args)
        {

            string testTekst = "Hello World!";

            Console.WriteLine(testTekst);
            Console.WriteLine(achterstevoren(testTekst));
            Console.WriteLine(achterstevoren(""));

            Console.WriteLine(testTekst);

            Console.WriteLine("--------------------------------");
            Console.WriteLine(optellen(10));
            Console.WriteLine(optellenKwadraat(10));
            Console.WriteLine("--------------------------------");

            Console.WriteLine("--------------------------------");
            Console.WriteLine(optellenKort(10));
            Console.WriteLine(optellenKwadraatKort(10));
            Console.WriteLine("--------------------------------");
        }

        static public void TestRecursie()
        {
            // .... hier jouw code om met NUnit te testen
        }


        static string achterstevoren(string tekst)
        {
            // stap 1 = stopconditie : wanneer stopt het algoritme
            if (tekst == "")
            {
                // stap 2: als ik gestopt ben: wat moet ik teruggeven? "Hoe wil ik het resultaat tot nu toe beinvloeden"?
                return "";
            }

            // stap 3 : wat is de kop? wat is de inhoud van het deelprobleem dat aan de beurt is? dus meestal:
            // - het huidige getal
            // - het item vooraan in de lijst
            // - de letter uit een tekst
            char huidigeSituatie = tekst[0];

            // stap 4: wat moet ik met de huidige doen? bijv.
            // - bewaren voor later optellen/aftrekken etc.
            // - converteer naar een kleine letter
            char resultaatHuidigeSituatie = huidigeSituatie;

            // stap 5: bepaal de staart: hoe krijg ik de staart gedefinieerd en in een variabele?
            // - pak een substring
            // - maak een kopie van de array zonder het eerste element
            // - bij getallen: verlaag bijv. het meegegeven getal met 1
            string staart = tekst.Substring(1); // substring begint bij nul te tellen, dus substring(1) is de tekst zonder het eerste karakter

            // stap 6: reken het resultaat uit van de staart door de functie opnieuw aan te roepen
            string resultaatVanDeStaart = achterstevoren(staart);

            // stap 7: voer de bewerking uit om het resultaat van de staart te combineren met die van de huidige resultaat:
            // let op: volgorde is van belang bij strings, aftrekken , deling van getallen!

            string resultaatFunctie = resultaatVanDeStaart + resultaatHuidigeSituatie;

            // stap 8: geef het resultaat terug.

            return resultaatFunctie;
        }    
        
        static int optellenKort(int n)
        {
            if (n == 0) { return 0; }
            return n + optellenKort(n - 1);
        }
                
        static int optellenKwadraatKort(int n)
        {
            if (n == 0) { return 0; }
            return (n*n) + optellenKwadraatKort(n - 1);
        }

        static int optellen(int n)
        {
            Console.WriteLine(n);
            // stap 1 = stopconditie : wanneer stopt het algoritme
            if (n == 0)
            {
                // stap 2: als ik gestopt ben: wat moet ik teruggeven? "Hoe wil ik het resultaat tot nu toe beinvloeden"?
                return 0;
            }

            // stap 3 : wat is de kop? wat is de inhoud van het deelprobleem dat aan de beurt is? dus meestal:
            // - het huidige getal
            // - het item vooraan in de lijst
            // - de letter uit een tekst
            int huidigeSituatie = n;

            // stap 4: wat moet ik met de huidige doen? bijv.
            // - bewaren voor later optellen/aftrekken etc.
            // - converteer naar een kleine letter
            int resultaatHuidigeSituatie = huidigeSituatie;

            // stap 5: bepaal de staart: hoe krijg ik de staart gedefinieerd en in een variabele?
            // - pak een substring
            // - maak een kopie van de array zonder het eerste element
            // - bij getallen: verlaag bijv. het meegegeven getal met 1
            int staart = n - 1; // zo maken we het deel wat nog uitgerekend moet worden steeds kleiner

            // stap 6: reken het resultaat uit van de staart door de functie opnieuw aan te roepen
            int resultaatVanDeStaart = optellen(staart);

            // stap 7: voer de bewerking uit om het resultaat van de staart te combineren met die van de huidige resultaat:
            // let op: volgorde is van belang bij strings, aftrekken , deling van getallen!

            int resultaatFunctie = resultaatHuidigeSituatie + resultaatVanDeStaart;

            // stap 8: geef het resultaat terug.

            return resultaatFunctie;
        }
        static int optellenKwadraat(int n)
        {
            Console.WriteLine(n);
            // stap 1 = stopconditie : wanneer stopt het algoritme
            if (n == 0)
            {
                // stap 2: als ik gestopt ben: wat moet ik teruggeven? "Hoe wil ik het resultaat tot nu toe beinvloeden"?
                return 0;
            }

            // stap 3 : wat is de kop? wat is de inhoud van het deelprobleem dat aan de beurt is? dus meestal:
            // - het huidige getal
            // - het item vooraan in de lijst
            // - de letter uit een tekst
            int huidigeSituatie = n;

            // stap 4: wat moet ik met de huidige doen? bijv.
            // - bewaren voor later optellen/aftrekken etc.
            // - converteer naar een kleine letter
            int resultaatHuidigeSituatie = huidigeSituatie * huidigeSituatie;
            Console.WriteLine(resultaatHuidigeSituatie);

            // stap 5: bepaal de staart: hoe krijg ik de staart gedefinieerd en in een variabele?
            // - pak een substring
            // - maak een kopie van de array zonder het eerste element
            // - bij getallen: verlaag bijv. het meegegeven getal met 1
            int staart = n - 1; // zo maken we het deel wat nog uitgerekend moet worden steeds kleiner

            // stap 6: reken het resultaat uit van de staart door de functie opnieuw aan te roepen
            int resultaatVanDeStaart = optellenKwadraat(staart);

            // stap 7: voer de bewerking uit om het resultaat van de staart te combineren met die van de huidige resultaat:
            // let op: volgorde is van belang bij strings, aftrekken , deling van getallen!

            int resultaatFunctie = resultaatHuidigeSituatie + resultaatVanDeStaart;

            
            // stap 8: geef het resultaat terug.

            return resultaatFunctie;
        }

    }
}
