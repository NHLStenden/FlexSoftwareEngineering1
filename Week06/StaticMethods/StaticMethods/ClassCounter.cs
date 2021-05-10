using System;
using System.Collections.Generic;
using System.Text;

namespace StaticMethods
{
    class ClassCounter
    {
        private static int counter;

        /// <summary>
        /// Default-constructor ('geen parameters') , maar deze verhoogd wel de teller. Let op: een OBJECT-instantie kan dus OOK bij de static variabelen!
        /// </summary>
        public ClassCounter()
        {
            ClassCounter.counter++;
        }
        
        /// <summary>
        /// Destructor; deze verlaagt de teller weer
        /// </summary>
        ~ClassCounter()
        {
            ClassCounter.counter--;
        }

        static ClassCounter()
        {
            counter = 0;
            Console.WriteLine("Static constructor:: init counter to zero");
        }

        /// <summary>
        /// Report the current number of instantiated classes
        /// </summary>
        /// <returns>The value of the static variable 'Counter'</returns>
        static public int Counter() {
            return ClassCounter.counter;
        }
    }
}
