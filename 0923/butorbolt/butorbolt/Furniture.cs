using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace butorbolt
{
    public class Furniture
    {
        public int Id { get; set; }
        public const double BasePrice = 25000;
        public Furniture(int id)
        {
            Id = id;
        }

        public virtual double Price()
        {
            return BasePrice;
        }

        public virtual void Print()
        {
            Console.WriteLine("Azonosító: " + Id);
            Console.WriteLine("Ár: " + Price() + " Ft");
        }
    }
}
