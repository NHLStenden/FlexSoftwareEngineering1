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
            throw new NotImplementedException();
        }//BerekenSomRecursiveOdd

        #endregion
    }
}