using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strand
{
    public class Vizibicikli : Cikk
    {
        public int SzemelyekSzama { get; set; }

        public Vizibicikli(string vonalkod, int szemelyekSzama) : base(vonalkod)
        {
            SzemelyekSzama = szemelyekSzama;
        }

        public override void Kiir()
        {
            Console.WriteLine("Vizibicikli");
            Console.WriteLine("Vonalkód: " + Vonalkod);
            Console.WriteLine("Személyek száma: " + SzemelyekSzama);
            Console.WriteLine("Kölcsönözve: "+ Kolcsonozve);
        }
    }
}
