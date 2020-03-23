using System;
using NUnit.Framework;

namespace Testing01
{
    // https://andrewlock.net/fixing-the-error-program-has-more-than-one-entry-point-defined-for-console-apps-containing-xunit-tests/
    // If your test project is already a console application, or includes a Program class with a static void main method,
    // then you must disable the auto-generation of the program file. Add the following element to your test project's .csproj,
    // inside a <PropertyGroup> element:
    // <GenerateProgramFile>false</GenerateProgramFile>
    // 
    
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        [Test]
        public static void TestMeOKE()
        {
            Assert.AreEqual(true, true);
        }
        
        [Test]
        public static void TestMeFail()
        {
            Assert.AreEqual(true, false);
        }


        [Test]
        static public void WeDoenEenTest()
        {
            Assert.AreEqual(true, BooleanNot(false));
            Assert.AreEqual(false, BooleanNot(true));
            Assert.AreNotEqual(true, BooleanNot(true));
            Assert.AreNotEqual(false, BooleanNot(false));

            Assert.AreEqual(true, BooleanOR(true, false));
            Assert.AreEqual(true, BooleanOR(false, true));

            Assert.AreEqual(true, true && true);
           
            Assert.AreEqual(15, ArrayOptellen(new int[]{ 1,2,3,4,5}));
            Assert.AreEqual(15, ArrayOptellen(new int[]{ 5,4,3,2,1}));
            Assert.AreEqual(10, ArrayOptellen(new int[]{ 5,5}));
            Assert.AreEqual(30, ArrayOptellen(new int[]{ 10,10,10}));
            Assert.AreEqual(16, ArrayOptellen(new int[]{ 1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1}));
        }

        static int ArrayOptellen(int[] arr)
        {
            int intResult = 0;
            for (int i = 0; i < arr.Length; i++) intResult += arr[i];
            return intResult;
        }

        static public bool ReturnValue(bool waarde)
        {
            Console.WriteLine("Return {0}", waarde);
            return waarde;
        }

        static public bool BooleanNot(bool waarde)
        {
            return !waarde;
        }
        static public bool BooleanOR(bool waarde1, bool waarde2)
        {
            return waarde1 || waarde2;
        }

    }
}