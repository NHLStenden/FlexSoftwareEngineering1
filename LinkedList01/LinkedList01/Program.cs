using System;
using TentamenFlex;

namespace LinkedList01
{
    class MartinsLijst : MyLinkedListInteger
    {
        public MartinsLijst()
        {
            Console.WriteLine("MartinsLijst::constructor {0}", this.head);
        }

        public void printHead()
        {
            Console.WriteLine("MartinsLijst::printHead {0}", this.head.Data);
        }

        public void printTwee()
        {
            Console.WriteLine("MartinsLijst::printTwee {0}", this.head.Next.Data);
        }
        public void printDrie()
        {
            Console.WriteLine("MartinsLijst::printDrie {0}", this.head.Next.Next.Data);
        }

        public void printN(int n)
        {
            MyLinkedListItem positie = this.head;

            int i = 0;

            while (i< n && positie != null)
            {
                positie = positie.Next;
                i++;
            }
            if (positie == null) {
                Console.WriteLine("printN = {0} #Error past end-of-list", n);
            }
            else
            {
                Console.WriteLine("printN = {0} {0}", n, positie.Data);
            }
            
        }        
        
        public void printWrong(int n)
        {
            int i = 0;

            while (i< n && this.head != null)
            {
                this.head = this.head.Next;
                i++;
            }
            if (this.head == null) {
                Console.WriteLine("printN = {0} #Error past end-of-list", n);
            }
            else
            {
                Console.WriteLine("printN = {0} {0}", n, this.head.Data);
            }
            
        }

        public void printNRecursive(int n)
        {
            MyLinkedListItem X = this.head;
            this.printNRecursiveLus(n, X);
        }

        private void printNRecursiveLus(int n, MyLinkedListItem X) { 
            if (X == null)
            {
                return;
            }
            if (n == 0)
            {
                Console.WriteLine(X.Data);
                return;
            }
/*          
            n = n - 1;
            X = X.Next;
*/            
            this.printNRecursiveLus(n-1, X.Next);
        }

        public void printReverse()
        {
            this.printReverseRecursive(this.head);
        }


        private  void printReverseRecursive(MyLinkedListItem X)
        {
            if (X == null)
            {
                return;
            }

            this.printReverseRecursive(X.Next);

            Console.WriteLine(X.Data);
        }

        public int TelAantal()
        {
            return this.Count(this.head);
        }
        
        private  int Count(MyLinkedListItem X)
        {
            if (X == null)
            {
                return 0;
            }

            int huidigeSituatie = 1;

            MyLinkedListItem startVanDeRestVanDeLijst = X.Next;

            int lengteVanDeRestVanDeLijst = this.Count(startVanDeRestVanDeLijst);

            int resultaat = huidigeSituatie + lengteVanDeRestVanDeLijst;

            return resultaat;
        }

        private  int CountShort(MyLinkedListItem X)
        {
            if (X == null) return 0;
            return 1 + this.Count(X.Next);
        }        

        public int Sommeren()
        {
            return this.Sum(this.head);
        }
        
        private  int Sum(MyLinkedListItem X)
        {
            if (X == null) return 0;
            return X.Data + this.Sum(X.Next);
        }

        public int SommeerMetLus()
        {
            int som = 0;
            MyLinkedListItem positie = this.head;
            while (positie != null)
            {
                som += positie.Data;
                positie = positie.Next;
            }
            return som;
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            MartinsLijst lijst = new MartinsLijst();

/*            lijst.AddItem(12);
            lijst.printHead();
            lijst.AddItem(334);
            lijst.printTwee();
            lijst.AddItem(9865);
            lijst.printDrie();
*/
            for(int i = 0; i < 20; i++)
            {
                lijst.AddItem(i);
            }
/*
            for(int i = 0; i < 20; i++)
            {
                lijst.printWrong(i);
            }*/

            lijst.printN(25);
            for (int i = 0; i < 20; i++)
            {
                lijst.printN(i);
            }

            lijst.printReverse();
            Console.WriteLine("Aantal items = {0}", lijst.TelAantal());
            Console.WriteLine("Som = {0}", lijst.Sommeren());
            Console.WriteLine("Som = {0}", lijst.SommeerMetLus());
            Console.WriteLine("Som = {0}", lijst.SommeerMetLus());
            Console.WriteLine("Som = {0}", lijst.SommeerMetLus());
            Console.WriteLine("Som = {0}", lijst.SommeerMetLus());
        }
    }
}
