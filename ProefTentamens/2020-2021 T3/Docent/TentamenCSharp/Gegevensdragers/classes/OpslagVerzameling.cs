using System;
using System.Collections.Generic;

namespace Gegevensdragers.classes
{
    public class OpslagVerzameling
    {
        private List<Gegevensdrager> items;

        public OpslagVerzameling()
        {
            this.items = new List<Gegevensdrager>();
        }

        public OpslagVerzameling add(Gegevensdrager item)
        {
            this.items.Add(item);
            return this;
        }

        public void report()
        {
            int aantal = this.items.Count;
            foreach (Gegevensdrager item in this.items)
            {
                item.report();
            }

            Console.WriteLine("------------------------");
            Console.WriteLine("{0} items gevonden", aantal);
        }
    }
}