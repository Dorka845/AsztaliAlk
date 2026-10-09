using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediatar
{
    public class Catalog
    {
        private readonly List<CatalogType> types = new();
        private int nextIdNumber = 1001;

        private static bool IsItAcceptable(string title, int realeseYear)
        {
            if (string.IsNullOrWhiteSpace(title))
            {
                Console.WriteLine("A cím nem lehet üres.");
                return false;
            }

            if (realeseYear < 1450)
            {
                Console.WriteLine(
                    "A kiadási év legalább 1450 legyen.");
                return false;
            }

            return true;
        }

        public void CatalogListing()
        {
            if (types.Count == 0)
            {
                Console.WriteLine("A katalógus üres.");
                return;
            }

            foreach (CatalogType type in types)
            {
                Console.WriteLine(type);
            }
        }


        public bool RegisterBook(string title, int realeseYear, string author, int pages)
        {
            if (!IsItAcceptable(title, realeseYear))
                return false;

            if (string.IsNullOrWhiteSpace(author))
            {
                Console.WriteLine("A szerző nem lehet üres.");
                return false;
            }

            if (pages <= 0)
            {
                Console.WriteLine("Az oldalszám legyen pozitív.");
                return false;
            }

            var book = new Book(
                nextIdNumber,
                title.Trim(),
                realeseYear,
                author.Trim(),
                pages);

            types.Add(book);
            nextIdNumber++;

            return true;
        }

        public bool RegisterJournal(string title, int releaseYear, string pages)
        {
            if (!IsItAcceptable(title, releaseYear))
                return false;

            if (string.IsNullOrWhiteSpace(pages))
            {
                Console.WriteLine("A lapszám nem lehet üres.");
                return false;
            }

            var journal = new Journal(
                nextIdNumber,
                title.Trim(),
                releaseYear,
                pages.Trim());

            types.Add(journal);
            nextIdNumber++;

            return true;
        }

        public bool RegisterDvd(string title, int releaseYear, string producer, int time)
        {
            if (!IsItAcceptable(title, releaseYear))
                return false;

            if (string.IsNullOrWhiteSpace(producer))
            {
                Console.WriteLine("A rendező nem lehet üres.");
                return false;
            }

            if (time <= 0)
            {
                Console.WriteLine("A játékidő legyen pozitív.");
                return false;
            }

            var dvd = new Dvd(
                nextIdNumber,
                title.Trim(),
                releaseYear,
                producer.Trim(),
                time);

            types.Add(dvd);
            nextIdNumber++;

            return true;
        }
    }
}
