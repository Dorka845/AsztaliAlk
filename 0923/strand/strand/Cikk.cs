using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strand
{
    public class Cikk
    {
        public string Vonalkod { get; set; }
        public bool Kolcsonozve { get; set; }

        public Cikk(string vonalkod)
        {
            Vonalkod = vonalkod;
            Kolcsonozve = false;
        }

        public void Kolcsonzes()
        {
            Kolcsonozve = true;
        }

        public void Visszahozas()
        {
            Kolcsonozve = false;
        }

        public virtual void Kiir()
        {
            Console.WriteLine("Vonalkód: " + Vonalkod);
            Console.WriteLine("Kölcsönözve: " + Kolcsonozve);
        }
    }
}
