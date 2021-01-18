using NUnit.Framework;
using System;

namespace AutomatischTesten01
{
    class Program
    {
        [Test]
        static public void testHello()
        {
            Assert.AreEqual("Hello", Hello());
        }

        [TestCase(1,2,ExpectedResult =3)]
        [TestCase(2,1,ExpectedResult =3)]
        [TestCase(10,20,ExpectedResult =30)]
        [TestCase(1,3,ExpectedResult = 4)]
        static public int optellen(int a, int b)
        {
            return a + b;
        }

        [TestCase(ExpectedResult="Hello") ]
        static public string Hello()
        {
            return "Hello";
        }

        [Test]
        static public void testSom()
        {
            Assert.AreEqual(78, CumulatieveSom(12));
        }

        [TestCase(12, ExpectedResult = 78)]
        [TestCase(1+2+3+4, ExpectedResult = 10)]
        static public int CumulatieveSom(int getal)
        {
            // Stop conditie
            if (getal == 0 )
            {
                // stop conditie
                return 0;
            }

            // wat moet ik met deze situatie doen? in dit geval : onthoudt het huidige getal
            int nuAanDeBeurt = getal;

            // wat is het resultaat van de rest die overgebleven is?
            // hamvraag => hoe kun je die 'rest' bepalen? 
            // in dit geval : de rest wordt bepaald door het huidige getal met 1 te verlagen
            int resultaatVanDeRest = CumulatieveSom(getal - 1);

            // hoe bepalen we het uiteindelijke resultaat? door de huidige situatie op te tellen
            // bij het resultaat van de rest.
            int hetResultaat = nuAanDeBeurt + resultaatVanDeRest;

            // geef dat resultaat terug
            return hetResultaat;
        }

    }
}
