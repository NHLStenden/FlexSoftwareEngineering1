using Drinkgerei01.classes;

namespace Drinkgerei01
{
    public class Amsterdammertje : Glas
    {
        public Amsterdammertje(int hoeveelheid) 
            :base(false, "bier", 25, hoeveelheid, 120, true, 100, 3)
        {
        }
    }
}