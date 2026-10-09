using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediatar
{
    public abstract class CatalogType
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int RealeseYear { get; set; }

        protected CatalogType(int id, string title, int realeseYear)
        {   
            Id = id;
            Title = title;
            RealeseYear = realeseYear;
        }

        public abstract string Type { get; }
        public abstract string Description { get; }
        public abstract int RentingDays { get; }
        public abstract int DayLateFee { get; }
        public override string ToString()
        {
            return $"[{Type}] {Id} {Title} " + $"{Description}, {RealeseYear}";
        }
    }
}
