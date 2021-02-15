using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TentamenFlex
{
    class StudentLinkedList : MyLinkedListInteger
    {
        public string CreateReverseTextRecursive()
        {
            //throw new NotImplementedException();
            return doCreateReverseTextRecursive(head);
        }//CreateReverseTextRecursive()

        private string doCreateReverseTextRecursive(MyLinkedListItem pos)
        {
            // stop conditie: als de positie NULL is dan zijn we aan het einde van de lijst.
            // return waarde is dan een lege string, omdat een lege string toevoegen aan een bestaand
            // resultaat geen negatieve effecten heeft
            if (pos == null) return "";

            // bepaal huidige situatie
            char kop = (char)('A' + pos.Data - 1);

            // bepaal de staart door de positie één te verschuiven
            MyLinkedListItem staartPositie = pos.Next;

            // bepaal het resultaat van de staart
            string staart = doCreateReverseTextRecursive(staartPositie);

            // voeg de staart en de kop samen. doordat "A" + "B" wat anders is dan "B" + "A" kun je een omkering van
            // de tekst bereiken door éérst de staart te noemen en daar de kop aan toe te voegen.
            return  staart + kop;

        }//doCreateReverseTextRecursive

        public string CreateReverseTextLoop()
        {
            // zorg dat we ons resultaat ergens op kunnen slaan
            string result = "";

            // wijs de startpositie aan. Let op: dit is een object van de klasse 'MyLinkedListItem '. 
            MyLinkedListItem start = head;

            // zolang we niet aan het einde van de lijst zijn...
            while (start != null)
            {
                // bepaal de letter van de huidige positie (zie tentamen voor uitleg over deze berekening)
                char letter = (char)('A' + start.Data - 1);

                // voeg de letter vóór het bestaande resultaat ! Zo krijg je de omkering eenvoudig voor elkaar.
                result = letter + result;

                // ga door naar het volgende item.
                start = start.Next;
            }

            return result;
        }//CreateReverseTextLoop
    }
}
