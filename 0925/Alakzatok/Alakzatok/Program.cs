namespace Alakzatok
{
    class Program
    {
        static void Main(string[] args)
        {
            Kor kor = new Kor();
            kor.Sugar = 5;
            Console.WriteLine("A kör területe: " kor.Terulet());
        }
    }

    abstract class Alakzat
    {
        public abstract double Terulet();
    }

    class Kor : Alakzat
    {
        public double Sugar { get; set; }

        public override double Terulet()
        {
            return Sugar * Sugar * Math.PI;
        }
    }

    class Negyzet : Alakzat
    {
        public double Oldal { get; set; }

        public override double Terulet()
        {
            return Oldal * Oldal;
        }
    }

    class Haromszog : Alakzat
    {
        public double Alap { get; set; }
        public double Magassag { get; set; }

        public override double Terulet()
        {
            return (Alap * Magassag) / 2;
        }
    }
}
