using NUnit.Framework;
using System;
using System.Collections.Generic;


namespace StackEnZo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int getal = 7;

            int result = functiona(getal);

            Console.WriteLine(result);


            List<int> mijnlijst = new List<int>();
            mijnlijst.Add(1);
            mijnlijst.Add(2);
            mijnlijst.Add(3);
            mijnlijst.Add(4);
            int count = refFunctionA(mijnlijst);

            Console.WriteLine(count);

        }

        [Test]
        static public void TestFunctionA()
        {
            Assert.AreEqual(64, functiona(7));
        }

        static int functiona(int x)
        {
            x = x + 1;
            int result = functionb(x);
            return result;
        }

        static int functionb(int y)
        {
            int result = functionc(y);
            return result;
        }

        static int functionc(int z)
        {
            int result = z * z;
            return result;
        }


        static int refFunctionA(List<int> lijstA)
        {
            refFunctionB(lijstA);
            return lijstA.Count;
        }
        static int refFunctionB(List<int> lijstB)
        {
            refFunctionC(lijstB);
            return lijstB.Count;
        }

        /// <summary>
        /// Deze gooit ook nog de lijst leeg! 
        /// </summary>
        /// <param name="lijstC">Een lijst met integers (die straks leeg)</param>
        /// <returns>0 want we de lijst leeg</returns>
        static int refFunctionC(List<int> lijstC)
        {
            // lijstC.Add(10);
            lijstC.Clear();

            return lijstC.Count;
        }


    }
}
