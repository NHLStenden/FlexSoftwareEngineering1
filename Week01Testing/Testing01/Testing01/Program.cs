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

    }
}