using System;
using MathProblems;
using NUnit.Framework;
using TentamenFlex;

namespace LinkedList
{
    class Program
    {
        
        [TestCase(9,  new int[] {1,2,3,4,5,6})]
        [TestCase(0,  new int[] {})]
        [TestCase(1,  new int[] {1})]
        [TestCase(4,  new int[] {3,1})]
        [TestCase(4,  new int[] {3,1,2})]
        [TestCase(4,  new int[] {3,1,2,4})]
        [TestCase(-1, new int[] {-1})]
        [TestCase(-4, new int[] {-1,-2,-3,-4})]
        [TestCase(0,  new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0 })]

        public static void TestDataSom(int result, int[] data)
        {
            StudentLinkedListInt list = new StudentLinkedListInt();
            for (int i = 0; i < data.Length; i++)
            {
                list.AddItem(data[i]);    
            }

            // De tests worden meerdere malen uitgevoerd op de lijst om aan te tonen dat de lijst door het opleveren van een som
            // niet kapot gaat en hergebruikt kan worden
            Assert.AreEqual(result, list.OnevenSom());
            Assert.AreEqual(result, list.OnevenSom());
            Assert.AreEqual(result, list.OnevenSom());
            Assert.AreEqual(result, list.OnevenSom());
        }//TestDataSom()

        [TestCase("654321",       new int[] { 1, 2, 3, 4, 5, 6 })]
        [TestCase("",             new int[] { })]
        [TestCase("1",            new int[] { 1 })]
        [TestCase("-1",           new int[] { -1 })]
        [TestCase("-3-2-1",       new int[] { -1, -2, -3 })]
        [TestCase("13",           new int[] { 3, 1 })]
        [TestCase("213",          new int[] { 3, 1, 2 })]
        [TestCase("101101010101", new int[] { 101,10,1010,101 })]

        public static void TestDataString(string result, int[] data)
        {
            StudentLinkedListInt list = new StudentLinkedListInt();
            for (int i = 0; i < data.Length; i++)
            {
                list.AddItem(data[i]);
            }

            // De tests worden meerdere malen uitgevoerd op de lijst om aan te tonen dat de lijst door het opleveren van een omgekeerde string
            // niet kapot gaat en hergebruikt kan worden
            Assert.AreEqual(result, list.Omdraaien());
            Assert.AreEqual(result, list.Omdraaien());
            Assert.AreEqual(result, list.Omdraaien());
            Assert.AreEqual(result, list.Omdraaien());
        }//TestDataString()
    }// class
}