using NUnit.Framework;
using System;
using System.Collections.Generic;

/// <summary>
/// This program is dependant of the following Nuget packages:
/// - Microsoft Microsoft.NET.Test.Sdk
/// - NUnit: 
///   - NUNit (v3)
///   - NUnit3TestAdapter
/// 
/// Furthermore: By installing these adapters, there is more than one entrypoint. 
/// You need tot select the right program to start using the 'Functions01'-properties in the project.
/// See attached image in this folder for the right settings./// 
/// 
/// </summary>


namespace Functions01
{
    class Program
    {
        
        static void Main(string[] args)
        {

            int getal = 10;

            VeranderParameter(getal);
            Console.WriteLine("Nieuwe waarde getal = {0}", getal);

            EchteVeranderParameter(ref getal );
            Console.WriteLine("Nieuwe waarde getal = {0}", getal);

            List<int> lijstje = new List<int>();
            int aantal = VoegToe(lijstje);

            foreach (var item in lijstje)
            {
                Console.WriteLine("Lijstje : {0}", item);
            }

            int deelresultaat;

            try
            {
                deelresultaat = Divide(10, 0);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Je mag niet delen door 0");
            }
            catch (Exception)
            {
                Console.WriteLine("Er gaat iets anders mis");
            }
            finally
            {
                Console.WriteLine("We gaan fijn weer verder");
            }

            


            Console.WriteLine("1 + 3 = {0}" , Add(1,3));
            Console.WriteLine("1 - 3 = {0}", Subtract(1,3));
            Console.WriteLine("1 x 3 = {0}", Multiply(1,3));
            Console.WriteLine("1 x 2 x 3 = {0}", Multiply(1, 2, 3));

            Console.WriteLine("3^2 = {0}", Square(3));
            Console.WriteLine("3^2 = {0}", Power(3,2));
            Console.WriteLine("3^2 = {0}", PowerRecursive(3,2));
            Console.WriteLine("3^4 = {0}", PowerRecursive(3,4));

            dommefunctie();
        }

        [Test]
        static public void TestAdd()
        {
            Assert.AreEqual(10, Add(5, 5));
            Assert.AreEqual(11, Add(5, 6));
            Assert.AreEqual(12, Add(5, 7));
            Assert.AreEqual(13, Add(5, 8));
            Assert.AreEqual(13, Add(8, 5));
        }

        [Test]
        static public void TestSub()
        {
            Assert.AreEqual(0, Subtract(5, 5));
            Assert.AreEqual(10, Subtract(5, -5));
            Assert.AreEqual(0, Subtract(1, 1));
            Assert.AreEqual(0, Subtract(0, 0));
        }


        [Test]
        static public void TestDivide()
        {
            // SEE: https://github.com/nunit/docs/wiki/Assert.Throws
            DivideByZeroException ex = Assert.Throws<DivideByZeroException>(() => { Divide(10, 0);  }); // Lambda Expression 

            Assert.AreEqual("Cannot divide 10 by 0", ex.Message);

            Assert.AreEqual(2, Divide(10, 5));
            Assert.AreEqual(3, Divide(10, 3)); // Good test: integer division!
        }

        static void dommefunctie()
        {
            Console.WriteLine("Domme functie");
        }

        static void VeranderParameter(int a)
        {
            a = a + 1;

        }

        /// <summary>
        /// Deze functie verandert wel de meegegeven parameter 'a'
        /// </summary>
        /// <param name="a">Deze parameter wordt 'by reference' meegegeven.</param>
        static void EchteVeranderParameter(ref int a)
        {
            a = a + 1;
        }

        static int VoegToe(List<int> locaalLijstje)
        {
            locaalLijstje.Add(10);
            locaalLijstje.Add(11);
            locaalLijstje.Add(12);
            locaalLijstje.Add(13);
            locaalLijstje.Add(14);

            return locaalLijstje.Count;
        }

        /// <summary>
        /// Return the multiplication of a and b
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>

        static int Multiply(int a, int b)
        {
            return a * b;
        }// Multiply

        static int Multiply(int a, int b, int c)
        {
            return a * b * c;
        }// Multiply

        /// <summary>
        /// Divides baseNr by the given divider
        /// </summary>
        /// <param name="baseNr"></param>
        /// <param name="divider"></param>
        /// <returns></returns>
        static int Divide(int baseNr, int divider) 
        {
            if (divider == 0) throw new DivideByZeroException("Cannot divide " + baseNr + " by 0");
            return baseNr / divider;
        }

        /// <summary>
        /// Returns the square of a (a times a)
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        static int Square(int a)
        {
            return Multiply(a, a);
        }

        /// <summary>
        /// Substracts b from a (result = a-b)
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static int Subtract(int a, int b)
        {
            return Add(a, -b);
        }
        /// <summary>
        /// Adds a to b
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static int Add(int a, int b)
        {
            return a + b;
        }
        /// <summary>
        /// returns x to the power p 
        /// Power (2,3) = 2*2*2
        /// Power (3,4) = 3*3*3*3
        /// </summary>
        /// <param name="x">ground number</param>
        /// <param name="p">power</param>
        /// <returns></returns>
        static int Power(int x, int p)
        {
            if (x == 0) return 0;
            if (p == 0) return 1;

            int result = x;

            for (int i = 1; i < p; i++)
            {
                result *= x;
            }

            return result;

        }
        /// <summary>
        /// Return x to the power p
        /// </summary>
        /// <param name="x">ground number</param>
        /// <param name="p">power</param>
        /// <returns></returns>
        static int PowerRecursive(int x, int p)
        {
            if (x == 0) return 0;
            if (p == 0) return 1;
            return x * Power(x, p - 1);
        }
    }
}
