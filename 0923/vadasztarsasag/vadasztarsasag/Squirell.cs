using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vadasztarsasag
{
    public class Squirell : Animal
    {
        public const double SquirellFactor = 1.2;

        public Squirell(string name) : base(name) { }

        public override double getPrice()
        {
            return BasePrice * SquirellFactor;
        }

    }
}
