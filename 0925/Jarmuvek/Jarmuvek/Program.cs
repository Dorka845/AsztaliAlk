namespace Jarmuvek
{
    class Program
    {
        static void Main(string[] args)
        {
            Jarmu jarmu = new Jarmu();
            jarmu.Sebesseg = 30;
            Console.WriteLine("A jármű sebessége: " + jarmu.Sebesseg);
            jarmu.Halad();
            Console.WriteLine("A jármű sebessége most: " + jarmu.Sebesseg);

            Auto auto = new Auto();
            auto.Sebesseg = 60;
            Console.WriteLine("Az autó sebessége: " + auto.Sebesseg);
            auto.Halad();
            Console.WriteLine("Az autó sebessége most: " + auto.Sebesseg);
            auto.Tankol();

            Bicikli bicikli = new Bicikli();
            bicikli.Sebesseg = 5;
            Console.WriteLine("A bicikli sebessége: " + bicikli.Sebesseg);
            bicikli.Halad();
            Console.WriteLine("A bicikli sebessége most: " + bicikli.Sebesseg);
            bicikli.Csenget();
        }
    }

    class Jarmu
    {
        public int Sebesseg { get; set; }

        public void Halad()
        {
            Sebesseg += 10;
        }
    }

    class Auto : Jarmu
    {
        public int Uzemanyag { get; set; }

        public void Tankol()
        {
            Console.WriteLine("Az auto tankol.");
        }
    }

    class Bicikli : Jarmu
    {
        public void Csenget()
        {
            Console.WriteLine("Csenget a bicikli.");
        }
    }
}
