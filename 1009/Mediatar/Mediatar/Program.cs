namespace Mediatar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var catalog = new Catalog();

            catalog.RegisterBook(
                "Egri csillagok",
                2018,
                "Gárdonyi Géza",
                520);

            catalog.RegisterDvd(
                "A Gyűrűk Ura: A Gyűrű Szövetsége",
                2001,
                "Peter Jackson",
                178);

            catalog.RegisterJournal(
                "Élet és Tudomány",
                2026,
                "2026/3");

            catalog.RegisterBook(
                "A Pál utcai fiúk",
                2015,
                "Molnár Ferenc",
                240);

            catalog.RegisterBook(
                "Abigél",
                2012,
                "Szabó Magda",
                360);

            catalog.RegisterBook(
                "Az arany ember",
                2010,
                "Jókai Mór",
                400);

            Console.WriteLine("=== Médiatár katalógusa ===");
            catalog.CatalogListing();
        }
    }
}
