using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediatar
{
    public class Dvd : CatalogType
    {
        public string Producer { get; }
        public int Time { get; }

        public override string Type => "DVD";

        public override string Description => $"– {Producer} ({Time} perc)";
        public override int RentingDays => 7;
        public override int DayLateFee => 100;

        public Dvd(
            int id,
            string title,
            int relaseseYear,
            string producer,
            int time)
            : base(id, title, relaseseYear)
        {
            Producer = producer;
            Time = time;
        }
    }
}
