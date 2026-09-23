namespace strand
{
    class Program
    {
        static void Main(string[] args)
        {
            Cikk[] cikkek = new Cikk[50];

            cikkek[0] = new Vizibicikli("VIZIBICIKLI00000000000000000001", 4);
            cikkek[1] = new Vizibicikli("VIZIBICIKLI00000000000000000002", 2);

            cikkek[2] = new Kenu("KENU000000000000000000000000001", 30, "Túra");
            cikkek[3] = new Kenu("KENU000000000000000000000000002", 25, "Verseny");

            cikkek[0].Kolcsonzes();
            cikkek[2].Kolcsonzes();

            for(int i = 0; i < cikkek.Length; i++)
            {
                if (cikkek[i] != null && cikkek[i].Kolcsonozve)
                {
                    cikkek[i].Kiir();
                    Console.WriteLine();
                }
            }
        }
    }
}
