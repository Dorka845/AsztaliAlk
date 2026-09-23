using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strand
{
    public class Kenu : Cikk
    {
        public int Tomeg { get; set; }
        public string Fajta { get; set; }

        public Kenu(string vonalkod, int tomeg, string fajta) : base(vonalkod)
        {
            Tomeg = tomeg;
            Fajta = fajta;
        }

        public override void Kiir()
        {
            Console.WriteLine("Kenu");
            Console.WriteLine("Vonalkód: " + Vonalkod);
            Console.WriteLine("Tömeg: " + Tomeg);
            Console.WriteLine("Fajta: " + Fajta);
            Console.WriteLine("Kölcsönözve: " + Kolcsonozve);
        }
    }
}
