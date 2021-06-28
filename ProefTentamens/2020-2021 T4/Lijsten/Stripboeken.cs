using System;
using System.Collections.Generic;
using System.Text;
using MyLinkedListClasses;

namespace Lijsten
{
    class Stripboeken : MyLinkedListIntString
    {
        public int BerekenKosten()
        {
            MyLinkedListItem head = this.head;

            int result = 0;

            while (head != null )
            {
                result += head.Getal;
                head = head.Next;
            }

            return result;
        }

        public void LeesBoeken()
        {
            this.LeesBoekenRecursive(this.head);
        }

        private void LeesBoekenRecursive(MyLinkedListItem item)
        {
            if (item == null ) { return; }
            Console.WriteLine("Lees boek: {0}", item.Naam);

            LeesBoekenRecursive(item.Next);
        }

        public void LegBoekenTerugInDeKast()
        {
            this.LegBoekenTerugInDeKastRecursive(this.head);
        }

        private void LegBoekenTerugInDeKastRecursive(MyLinkedListItem item)
        {
            if (item == null) { return; }
            LegBoekenTerugInDeKastRecursive(item.Next);

            Console.WriteLine("Terug in de kast: {0} ", item.Naam);
        }
    }
}
