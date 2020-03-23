# Huiswerk 01
Dit huiswerk gaat over het uitwerken van een drietal opdrachten met recursie


We gaan uit van de volgende code voor de Main-functie:

```C#
static void Main(string[] args)
        {
            // Zoek alle getallen waarvan de wortel een geheel getal is.
            List<int> sqrts = new List<int>();
            FindAllIntegerSQRT(100, sqrts);
            sqrts.Sort();
            foreach (int sqrt in sqrts) Console.WriteLine(sqrt);

            // Zoek alle priemgetallen tot en met 15000
            List<int> primes = FindPrimes(15000);
            foreach (int prime in primes) Console.WriteLine(prime);

            // zoek een aantal woorden die omgekeerd hetzelfde woord vormen (Palindroom)
            String testWoord = "lepels";
            bool isPalindroom = TestPalindroom(testWoord);
            Console.WriteLine("{0} is {1} palindroom", testWoord, isPalindroom ? "een" : "geen");

            testWoord = "lepel";
            isPalindroom = TestPalindroom(testWoord);
            Console.WriteLine("{0} is {1} palindroom", testWoord, isPalindroom ? "een" : "geen");

            testWoord = "piet";
            isPalindroom = TestPalindroom(testWoord);
            Console.WriteLine("{0} is {1} palindroom", testWoord, isPalindroom ? "een" : "geen");

            Console.ReadKey();

        }

```

## Opdracht 1: integer wortels zoeken

De eerste opdracht betreft het zoeken naar alle getallen waarvan de wortel een geheel getal is.
Bijvoorbeeld:
  * wortel (9) = 3 , dat is een geheel getal
  * wortel (36) = 6, dat is een geheel getal
  * wortel (10) = 3,1622776601683793319988935444327 en dat is geen geheel getal

De functie `FindAllIntegerSQRT` zoekt alle getallen tot en met een bepaald meegegeven
getal (in het voorbeeld is dat 100). De gevonden getallen plaats je in een lijst die
je van tevoren meegeeft.

Om te kijken of de uitkomst een geheel getal is vergelijk je de wortel met de Floor-waarde van 
de wortel. 
```C#
  bool isInteger = Math.Abs(Math.Floor(wortel) - wortel) < 0.00001;
```


## Referenties
  * [https://docs.microsoft.com/en-us/dotnet/api/system.math.floor?f1url=https%3A%2F%2Fmsdn.microsoft.com%2Fquery%2Fdev15.query%3FappId%3DDev15IDEF1%26l%3DEN-US%26k%3Dk(System.Math.Floor);k(TargetFrameworkMoniker-.NETFramework,Version%3Dv4.6.1);k(DevLang-csharp)%26rd%3Dtrue&view=netframework-4.8](Floor functie)
  


## Opdracht 2: zoek priemgetallen
De tweede opdracht gaat over het zoeken naar priemgetallen. Er zijn vele methodes om dit te doen,
maar de simpelste is door te kijken of er een deler is die een geheel getal oplevert. Zie de vorige
opdracht hoe je dat kunt doen.

Deze functie dien je recursief op te lossen. Je kunt je recursieve functie nog optimaliseren door
niet te starten bij het getal zelf met zoeken naar delers, maar bij het getal gedeeld door 2. De 
reden hier achter is dat het getal 2 (naast 1 natuurlijk) de kleinste deler is die een 
geheel getal kan opleveren. Dus als je wilt kijken of 15 een priemgetal is, dan begin met het zoeken
naar delers met het getal 8. 

Let op: de aanroep van de functie geeft hier geen mogelijkheid toe, dus je moet in dat geval
een hulpfunctie gebruiken.

## Opdracht 3: Palindroom zoeken
De derde opdracht gaat over het zoeken naar een palindroom. Dat is in wezen erg simpel het woord om te draaien
met bijvoorbeeld recursie. Echter er is een snellere methode: kijk of de eerste en laatste letter gelijk zijn. 
Zo ja: gaan dan verder met de letters die daar binnen vallen. Je krijgt dan onderstaande:

 * LEPEL ==> Eerste en laatste letter zijn gelijk; vergelijk het restant zonder de buitenste letters
 *  EPE  ==> Eerste en laatste letter zijn gelijk; vergelijk het restant zonder de buitenste letters
 *   P   ==> Er resteert 1 letter.
Dus een palindroom

 * REDDER
 *  EDDE
 *   DD
Deze eindigt met twee dezelfde letters, dus ook een palindroom.
  
  
Deze vorm van recursie maakt dus niet zozeer gebruik van een 'kop' en een 'staart', maar wel van een huidige
situatie en een 'restant'.


  