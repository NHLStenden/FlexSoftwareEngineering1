using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TentamenFlex
{
    /**
 * Gebruikt de volgende Nuget packages:
 * - microsoft.net.test.dsk
 * - NUnit
 * - NUnit3TestAdapter
 */
    class Program
    {
             
        #region Vraag 3 - Recursief
        [Test]
        public static void TestList2Recursief()
        {
            StudentLinkedList myList = new StudentLinkedList();
            Assert.AreEqual("", myList.CreateReverseTextRecursive());

            myList.AddItem(1);
            Assert.AreEqual("A", myList.CreateReverseTextRecursive());

            myList.AddItem(2);
            myList.AddItem(3);
            myList.AddItem(4);
            myList.AddItem(5);

            Assert.AreEqual("EDCBA", myList.CreateReverseTextRecursive());
            Assert.AreEqual("EDCBA", myList.CreateReverseTextRecursive());

            myList.clear();
            myList.AddItem(7);
            myList.AddItem(15);
            myList.AddItem(5);
            myList.AddItem(4);
            myList.AddItem(7);
            myList.AddItem(5);
            myList.AddItem(4);
            myList.AddItem(1);
            myList.AddItem(1);
            myList.AddItem(14);
            Assert.AreEqual("NAADEGDEOG", myList.CreateReverseTextRecursive());
            Assert.AreEqual("NAADEGDEOG", myList.CreateReverseTextRecursive());
        }
        #endregion

        #region Vraag 3 - Met normale lus
        [Test]
        public static void TestList2Loop()
        {
            StudentLinkedList myList = new StudentLinkedList();
            Assert.AreEqual("", myList.CreateReverseTextLoop());

            myList.AddItem(1);
            Assert.AreEqual("A", myList.CreateReverseTextLoop());

            myList.AddItem(2);
            myList.AddItem(3);
            myList.AddItem(4);
            myList.AddItem(5);

            Assert.AreEqual("EDCBA", myList.CreateReverseTextLoop());
            Assert.AreEqual("EDCBA", myList.CreateReverseTextLoop());

            myList.clear();
            myList.AddItem(7);
            myList.AddItem(15);
            myList.AddItem(5);
            myList.AddItem(4);
            myList.AddItem(7);
            myList.AddItem(5);
            myList.AddItem(4);
            myList.AddItem(1);
            myList.AddItem(1);
            myList.AddItem(14);
            Assert.AreEqual("NAADEGDEOG", myList.CreateReverseTextLoop());
            Assert.AreEqual("NAADEGDEOG", myList.CreateReverseTextLoop());
        }
        #endregion
        
    }


}


