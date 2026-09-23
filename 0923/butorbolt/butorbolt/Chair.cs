using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace butorbolt
{
    public class Chair : Furniture
    {
        public const double ChairFactor = 1.2;
        public int Legs { get; set; }

        public Chair(int legs, int id) : base(id)
        {
            Legs = legs;
        }
        public override double Price()
        {
            return BasePrice * ChairFactor;
        }

        public override void Print()
        {
            Console.WriteLine("Szék");
            Console.WriteLine("Azonosító: " + Id);
            Console.WriteLine("Lábak száma: " + Legs);
            Console.WriteLine("Ár: " + Price() + " Ft");
        }
    }
}
