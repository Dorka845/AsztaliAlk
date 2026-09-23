using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace butorbolt
{
    public class Bed : Furniture
    {
        public const double BedFactor = 2.4;
        public int Length { get; set; }
        public int Width { get; set; }

        public Bed(int id, int width, int length) : base(id)
        {
            Width = width; 
            Length = length;
        }

        public override double Price()
        {
            return BasePrice * BedFactor;
        }

        public override void Print()
        {
            Console.WriteLine("Ágy");
            Console.WriteLine("Azonosító: " + Id);
            Console.WriteLine("Hossz: " + Length);
            Console.WriteLine("Szélesség: " + Width);
            Console.WriteLine("Ár: " + Price() + " Ft");
        }
    }
}
