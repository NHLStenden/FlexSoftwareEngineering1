using System.Linq;
using System.Collections.Generic;

namespace OperatorOverloading
{
    class SpecialList
    {
        private List<int> items;
        public SpecialList()
        {
            this.items = new List<int>();
            foreach(int number in Enumerable.Range(1, 10))
            {
                items.Add(number);
            }
        }

        public int this[int i]
        {
            get { return this.items[i];   }
            set { this.items[i] = value;  }
        }
    }
}
