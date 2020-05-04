using NUnit.Framework;
using System;

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
            Console.WriteLine("1 + 3 = {0}" , Add(1,3));
            Console.WriteLine("1 - 3 = {0}", Subtract(1,3));
            Console.WriteLine("1 x 3 = {0}", Multiply(1,3));
            Console.WriteLine("3^2 = {0}", Square(3));
            Console.WriteLine("3^2 = {0}", Power(3,2));
            Console.WriteLine("3^2 = {0}", PowerRecursive(3,2));
            Console.WriteLine("3^4 = {0}", PowerRecursive(3,4));
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
            DivideByZeroException ex = Assert.Throws<DivideByZeroException>(() => { Divide(10, 0);  });
            Assert.AreEqual("Cannot divide 10 by 0", ex.Message);

            Assert.AreEqual(2, Divide(10, 5));
            Assert.AreEqual(3, Divide(10, 3)); // Good test: integer division!
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
