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
    }
}
