using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vadasztarsasag
{
    public class PolarBear : Animal
    {
        public const double PolarBearFactor = 2.4;

        public PolarBear(string name) : base(name) { }

        public override double getPrice()
        {
            return BasePrice * PolarBearFactor;
        }
    }
}
