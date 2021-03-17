using System;
using System.Collections.Generic;
using System.Text;
using TentamenFlex;

namespace Koeriersdienst
{
    class StudentLinkedListString : TentamenFlex.MyLinkedListString
    {
        public int PakketjesLijst()
        {
            return PakketjesLijstRecursive(this.head);
        }

        private int PakketjesLijstRecursive(MyLinkedListItem item)
        {
            if (item == null) return 0;
            Console.WriteLine(item.Data);
            return 1 + PakketjesLijstRecursive(item.Next);
        }

        public void RouteLijst()
        {
            RouteLijstRecursive(this.head, 1);
        }

        private void RouteLijstRecursive(MyLinkedListItem item, int ordernr)
        {
            if (item == null) return;
            RouteLijstRecursive(item.Next, ordernr + 1);
            Console.WriteLine("{0} - {1}", ordernr, item.Data);
        }
    }
}
