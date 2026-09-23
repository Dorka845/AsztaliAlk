using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace butorbolt
{
    public class Table : Furniture
    {
        public const double TableFactor = 0.3;
        public int Height { get; set; }
        public Table(int id, int height) : base(id)
        {
            Height = height;
        }

        public override double Price()
        {
            return BasePrice * TableFactor;
        }

        public override void Print()
        {
            Console.WriteLine("Asztal");
            Console.WriteLine("Azonosító: " + Id);
            Console.WriteLine("Magasság: " + Height);
            Console.WriteLine("Ár: " + Price() + " Ft");
        }
    }
}
