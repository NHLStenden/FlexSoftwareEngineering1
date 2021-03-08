using System;
using System.Collections.Generic;
using System.Text;
using TentamenFlex;

namespace MyLinkedListTester
{
    class LinkedListStudent : MyLinkedListString
    {
        public void ListStations()
        {
            // we maken gebruik van een hulpfunctie om de recursie te starten
            ListStationsRecursive(this.head);
        }

        private void ListStationsRecursive(MyLinkedListItem item)
        {
            // stop conditie
            if (item == null) return;

            // behandelen van de huidige situatie
            Console.WriteLine(item.Data);

            // behandelen van de staart
            ListStationsRecursive(item.Next);
        }

        public void ListRetourRoute()
        {
            // we maken gebruik van een hulpfunctie om de recursie te starten
            this.ListRetourRouteRecursive(this.head);
        }
        public void ListRetourRouteRecursive(MyLinkedListItem item)
        {
            // stop conditie
            if (item == null) return;

            // eerst behandelen van de staart, dan pas huidige situatie ==> omkering van output
            ListRetourRouteRecursive(item.Next);

            // behandel huidige situatie
            Console.WriteLine(item.Data);
        }
    }
}
