using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediatar
{
    public class Journal : CatalogType
    {
        public string PageNumber { get; }

        public override string Type => "Folyóirat";

        public override string Description => $"({PageNumber})";
        public override int RentingDays => 7;
        public override int DayLateFee => 50;

        public Journal(
            int id,
            string title,
            int realeseYear,
            string pageNumber)
            : base(id, title, realeseYear)
        {
            PageNumber = pageNumber;
        }
    }
}
