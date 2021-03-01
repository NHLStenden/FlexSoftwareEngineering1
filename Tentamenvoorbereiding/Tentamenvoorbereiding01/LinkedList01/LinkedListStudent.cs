using System;
using System.Collections.Generic;
using System.Text;
using TentamenFlex;

namespace LinkedList01
{
    class LinkedListStudent : MyLinkedListString
    {
        public void ListItems()
        {
            MyLinkedListItem node = this.head;

            while (node != null)
            {
                string data = node.Data;
                Console.WriteLine(data);

                node = node.Next;
            }
        }// ListItems

        public void ListItemsFout()
        {
            /**
             * Het probleem hier is dat je this.head steeds verplaatst. Uiteindelijk kom je uit bij NULL
             * en wijst de this.head nergens meer naar. Je bent dus de verbinding met het eerste item kwijtgeraakt 
             * 
             * oplossing => maak altijd een aparte variabele waarmee je langs de lijst loopt (zie hierboven de variabele 'node')
             *              initialisatie met de waarde van de head en stoppen als NULL
             */ 
            while (this.head != null)
            {
                string data = this.head.Data;
                Console.WriteLine(data);
                // nu ben je de waarde van de head aan het veranderen.
                this.head = this.head.Next;
            }
        }// ListItemsFout



        public void ListItemsReverse()
        {
            ListItemsReverseRecursive(this.head);
        }

        public void ListItemsForward()
        {
            ListItemsForwardRecursive(this.head);
        }

        private void ListItemsReverseRecursive(MyLinkedListItem item)
        {
            if (item == null)
            {
                return ;
            }
            ListItemsReverseRecursive(item.Next);

            Console.WriteLine(item.Data);
        }        
        
        private void ListItemsForwardRecursive(MyLinkedListItem item)
        {
            if (item == null)
            {
                return ;
            }
            Console.WriteLine(item.Data);

            ListItemsReverseRecursive(item.Next);

        }
    }
}
