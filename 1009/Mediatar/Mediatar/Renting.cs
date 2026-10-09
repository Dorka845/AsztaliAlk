using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Mediatar
{
    public class Renting
    {
        public Customer Customer { get; }
        public CatalogType Type { get; }
        public DateTime RentingDate { get; }
        public DateTime Deadline { get; }

        public Renting(Customer customer, CatalogType type, DateTime date)
        {
            Customer = customer;
            Type = type;
            RentingDate = date;
            Deadline = date.AddDays(type.RentingDays);
        }
    }
}
