using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Mediatar
{
    public class Book : CatalogType
    {
        public string Author { get; }
        public int Pages { get; }

        public override string Type => "Könyv";
        public override string Description => $"– {Author} ({Pages} oldal)";
        public override int RentingDays => 28;
        public override int DayLateFee => 20;

        public Book(int id, string title, int realeseYear, string author, int pages) 
            : base(id, title, realeseYear)
        {
            Author = author;
            Pages = pages;
        }
    }
}
