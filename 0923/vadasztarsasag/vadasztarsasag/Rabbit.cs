using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vadasztarsasag
{
    public class Rabbit : Animal
    {
        public const double RabbitFactor = 0.3;

        public Rabbit(string name) : base(name) { }

        public override double getPrice()
        {
            return BasePrice * RabbitFactor;
        }
    }
}
