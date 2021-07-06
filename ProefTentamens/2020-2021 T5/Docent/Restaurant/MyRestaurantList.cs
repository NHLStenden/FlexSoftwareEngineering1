using MyLinkedListClasses;
using System;

namespace TentamenFlexHerkansing
{
    class MyRestaurantList : MyLinkedListIntString
    {
        public void showVisitorChanges()
        {
            MyLinkedListItem item = head;
            int counter = 0;
            int max = 0;
            while (item!= null)
            {
                counter += item.Getal;
                if (counter > max ) { max = counter; }
                Console.Write("{0}|",item.Naam);
                this.DrawBar(counter);
                Console.WriteLine();
                item = item.Next;
            }
            this.DrawXAxis(max);

        }

        private void DrawBar(int nrOfItems)
        {
            Console.Write("".PadRight(nrOfItems, '#'));
        }

        private void DrawXAxis(int nrOfItems)
        {
            Console.Write("        ");
            int i = 0;
            for (; i < nrOfItems; i++)
            {
                if (i % 10 == 0)
                {
                    Console.Write('|');
                }
                else
                {
                    Console.Write('-');
                }
            }
            while (i % 10 != 0)
            {
                Console.Write('-');
                i++;
            }
            Console.WriteLine('|');
        }


        public int GetLargestGroup()
        {
            return this.GetLargestGroupRecursive(this.head, 0);
        }

        private  int GetLargestGroupRecursive(MyLinkedListItem item, int max)
        {
            if (item == null)
            {
                return max;
            }
            if (item.Getal > max)
            {
                max = item.Getal;
            }
            int result = GetLargestGroupRecursive(item.Next, max);
            return result;
        }
    }
}
