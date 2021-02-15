using System;
using System.Collections.Generic;
using System.Text;

namespace Vervoersmiddelen
{

    enum AantalDeurenEnum
    {
        drie = 3, 
        vijf = 5, 
        twee = 2, 
        vier = 4
    }

    class Auto : Vervoersmiddel
    {
        private AantalDeurenEnum deuren;
        public Auto(AantalDeurenEnum deuren, string autokleur) : base(4, autokleur)
        {
            this.deuren = deuren;
        }

        public override int SnelheidPlus(int delta)
        {
            Console.WriteLine("Druk het gaspedaal verder in met {0}", delta);
            return base.SnelheidPlus(delta);
        }

        public override int SnelheidMin(int delta)
        {
            Console.WriteLine("Druk een tijdje op de rem");
            return base.SnelheidMin(delta);
        }

        public int AantalDeuren()
        {
            switch(this.deuren)
            {
                case AantalDeurenEnum.drie:
                    return 3;
                case AantalDeurenEnum.twee:
                    return 2;
                case AantalDeurenEnum.vijf:
                    return 5;
                case AantalDeurenEnum.vier:
                    return 4;
                default:
                    return -1;
            }
        }
    }
}
