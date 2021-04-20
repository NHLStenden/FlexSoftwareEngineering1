using System;
using TentamenFlex;

namespace MathProblems
{
    class StudentLinkedListInt : TentamenFlex.MyLinkedListInteger
    {

        public int OnevenSom()
        {
            return this.OnevenSomRecursive(this.head);
        }
        public int OnevenSomRecursive(MyLinkedListItem item)
        {
            if (item == null) return 0;
            if (item.Data % 2 != 0)
            {
                return item.Data + this.OnevenSomRecursive(item.Next);
            }
            else
            {
                return this.OnevenSomRecursive(item.Next);
            }
        }

        public string Omdraaien()
        {
            return this.OmdraaienRecursive(this.head);
        }

        private string OmdraaienRecursive(MyLinkedListItem item)
        {
            /*          
             *          Korte variant: 
             *          
             *          if (item == null) return "";
                        return OmdraaienRecursive(item.Next) + item.Data.ToString();
            */

            /** lange variant **/

            if (item == null) return "";
            string huidigeSituatie = item.Data.ToString();

            MyLinkedListItem volgendeItem = item.Next;

            string resultaatRestant = this.OmdraaienRecursive(volgendeItem);

            return resultaatRestant + huidigeSituatie;
        
        }

    }
}
