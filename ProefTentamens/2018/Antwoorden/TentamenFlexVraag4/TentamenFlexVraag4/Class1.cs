using System;
using NUnit.Framework;

namespace TentamenFlexVraag4
{
    /**
 * Gebruikt de volgende Nuget packages:
 * - microsoft.net.test.dsk
 * - NUnit
 * - NUnit3TestAdapter
 */
    class Program
    {
        #region Vraag4: 
        [Test]
        public void TestBerekenSomRecursiveOdd()
        {
            Assert.AreEqual(4,  BerekenSomRecursiveOdd(new int[] { 1, 2, 3, 4 }));
            Assert.AreEqual(4,  BerekenSomRecursiveOdd(new int[] { 1, 4, 3, 2 }));
            Assert.AreEqual(3,  BerekenSomRecursiveOdd(new int[] { 4, 4, 4, 4, 4, 4, 4, 4, 4, 3 }));
            Assert.AreEqual(6,  BerekenSomRecursiveOdd(new int[] { 1, 1, 1, 1, 1, 1 }));
            Assert.AreEqual(14, BerekenSomRecursiveOdd(new int[] { 1, 3, 3, 3, 3, 1 }));
            Assert.AreEqual(0,  BerekenSomRecursiveOdd(new int[] { }));
            Assert.AreEqual(1,  BerekenSomRecursiveOdd(new int[] { 1 }));
            Assert.AreEqual(0,  BerekenSomRecursiveOdd(new int[] { 0 }));
            Assert.AreEqual(0,  BerekenSomRecursiveOdd(new int[] { 2 }));
        }//TestCountLettersRecursive

        private static int BerekenSomRecursiveOdd(int[] getallen)
        {
            //throw new NotImplementedException();

            // we gebruiken een hulp functie om de echte recursie te starten met een extra parameter
            // deze extra parameter is bedoeld om de positie van de "kop" aan te wijzen. 
            return BerekenSomRecursiveOddPos(getallen, 0);
        }//BerekenSomRecursiveOdd

        private static int BerekenSomRecursiveOddPos(int[] getallen, int pos)
        {
            // stop conditie
            if (pos >= getallen.Length) return 0;

            // bepaal huidige resultaat
            int item = getallen[pos];

            // huidige situatie: als even (dus niet ODD), dan huidige resultaat = 0;
            if (item % 2 == 0) item = 0;

            //return huidige resultaat + resultaat van de rest
            // het restant (de 'staart') wordt bepaald door de positie één op te schuiven.
            return item + BerekenSomRecursiveOddPos(getallen, pos + 1);
        }//BerekenSomRecursiveOddPos
        #endregion
    }
}