using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week01_testing
{
    class Program
    {
        static void Main(string[] args)
        {
           if (ReturnValue(true) && ReturnValue(true))
            {
                Console.WriteLine("Beide true");

            }

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
