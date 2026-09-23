using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tihi_oriasTeknos
{
    public class Crab : Food
    {
        public int Meret { get; set; }

        public Crab(int meret)
        {
            Meret = meret;
        }

        public override int Value()
        {
            return Meret * 10;
        }
    }
}
