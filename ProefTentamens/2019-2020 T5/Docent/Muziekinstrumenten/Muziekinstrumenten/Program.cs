using System;

namespace Muziekinstrumenten
{
    class Program
    {
        static void Main(string[] args)
        {

            Orkest orkest = new Orkest();
            Saxofoon sax1 = new Saxofoon("sax 1",  "alt");
            Saxofoon sax2 = new Saxofoon("sax 2", "alt");

            Blokfluit fluit1 = new Blokfluit("Stenberg");
            Blokfluit fluit2 = new Blokfluit("Thijs van Leer");

            AkoestischePiano piano = new AkoestischePiano("martin");
            AkoestischePiano grandpiano = new AkoestischePiano("Diana Krall");

            Synthesizer synth1 = new Synthesizer("Rick Wakeman");
            synth1.AddGeluid("Drumstel");
            synth1.AddGeluid("Gitaar");
            synth1.AddGeluid("Contrabas");

            Toetsinstrumenten xyz = new Toetsinstrumenten("Raar ding",21);

            orkest.AddInstrument(sax1);
            orkest.AddInstrument(sax2);
            orkest.AddInstrument(piano);
            orkest.AddInstrument(grandpiano);
            orkest.AddInstrument(synth1);
            orkest.AddInstrument(fluit1);
            orkest.AddInstrument(fluit2);
            orkest.AddInstrument(xyz);
            orkest.MaakMuziek();

        }
    }
}
