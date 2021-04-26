using System;

/// <summary>
/// Dit voorbeeld zou  oorspronkelijk over Electronische Apparatuur gaan (zie .drawio bestand in de bovenliggende folder), maar hierin zaten onvoldoende
/// aanknopingpunten om met de constructors te werken met vaste / variabele waarden. daarom is een voorbeeld uit de presentatie gekozen waarbij een auto
/// en vervoersmiddel gebruikt worden. 
/// </summary>
namespace ElectronischeApparatuur
{
    class Vervoersmiddel
    {
        /// <summary>
        /// standaard zijn alle variabelen in C# gedefinieerd als PRIVATE binnen een klasse. dit kan voor andere talen anders gedefinieerd zijn.
        /// de variabelen zijn hier voor de duidelijkheid expliciet ingesteld op private.
        /// </summary>
        private string kleur;
        private string fabrikant;
        private int wielen;
        private int huidigeSnelheid;

        /// <summary>
        /// Dit is de constructor die aangeroepen wordt als deze klasse óf een onderliggende klasse gebouwd wordt. 
        /// </summary>
        /// <param name="kleur">De kleur van de auto</param>
        /// <param name="fabrikant">De fabrikant van de auto</param>
        /// <param name="wielen">Het aantal wielen (er vind geen check plaats op negatieve waarden!)</param>
        public Vervoersmiddel(string kleur, string fabrikant, int wielen)
        {
            this.kleur = kleur;
            this.fabrikant = fabrikant;
            this.wielen = wielen;
            this.zetSnelheid(0);  // in plaats van rechtstreeks de waarde in te stellen gebruiken we een nette methode
        }

        /// <summary>
        /// Deze methode stelt de huidige snelheid in op de aangegeven waarde 'v'
        /// </summary>
        /// <param name="v">De nieuwe huidige snelheid</param>
        public void zetSnelheid(int v)
        {
            this.huidigeSnelheid = v;
        }
    }// clas Vervoersmiddel


    /// <summary>
    /// Deze klasse Auto erft van de klasse Vervoersmiddel. Het opvallendste is dat het aantal wielen vast staat op de waarde 4
    /// en dus niet meegegeven hoeft te worden bij het aanmaken van een auto.
    /// 
    /// Verder voegen we voor een auto een nieuwe eigenschap toe: het aantal deuren. Omdat elke (type) auto een ander aantal deuren kan hebben 
    /// is het noodzakelijk dat deze bij de constructor meegegeven wordt. 
    /// </summary>
    class Auto : Vervoersmiddel
    {
        /// <summary>
        /// een nieuwe variabele om het aantal deuren te registreren. deze dient in de constructor opgegeven te worden.
        /// </summary>
        int aantalDeuren;

        /// <summary>
        /// Deze constructor zorgt voor de initialisatie van een object op basis van de klasse Auto. Eerst wordt de bovenliggende constructor
        /// (Vervoersmiddel.Vervoersmiddel) aangeroepen door middel van het sleutelwoord 'base' met de parameters kleur, fabrikant en de vaste waarde 4 
        /// voor het aantal wielen. 
        /// </summary>
        /// <param name="aantalDeuren">Het aantal deuren</param>
        /// <param name="kleur">De kleur van de auto</param>
        /// <param name="fabrikant">De fabrikant</param>
        public Auto(int aantalDeuren, string kleur, string fabrikant) : base(kleur, fabrikant, 4)
        {
            this.aantalDeuren = aantalDeuren;
        }
    }

    /// <summary>
    /// Deze klasse zorgt voor het beschikbaar komen van de klasse  Renault. Opvallend is hier dat de fabrikant dus altijd Renault is. We kunnen deze
    /// dus weglaten uit de constructor van DEZE klasse, en geven een vaste waarde mee aan de bovenliggende constructor (Auto.Auto).
    /// Let op: de aanroep 'base' verwijst dus in dit geval naar de klasse 'Auto' en niet naar 'Vervoersmiddel'!
    /// </summary>
    class Renault: Auto
    {
        public Renault(int aantalDeuren, string kleur) : base (aantalDeuren, kleur, "Renault")
        {
            // doordat we verder geen speciale of nieuwe waarden hoeven aan te passen is dit verder een lege constructor. 
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Vervoersmiddel v1 = new Vervoersmiddel("wit", "Opel", 3);

            Auto audi = new Auto(3, "Rood", "Audi");

            // zie het verschil in het aanmaken van een Auto of Renault: de Renault kent geen parameter voor de fabrikant: die staat vast op 'Renault'!
            Renault clio = new Renault(3, "Geel");
        }



    }
}
