using System.Runtime.CompilerServices;

namespace Jarmuvek
{
    class Program
    {
        static void Main(string[] args)
        {
            IJarmu[] jarmuvek = {
                new Auto(),
                new Bicikli()
            };

            foreach (var item in jarmuvek)
            {
                item.Indit();
                item.Megall();
            }
        }
    }

    public interface IJarmu
    {
        void Indit();
        void Megall();
    }

    public class Auto : IJarmu
    {
        public void Indit()
        {
            Console.WriteLine("Az autó motorja beindult.");
        }

        public void Megall()
        {
            Console.WriteLine("Az autó megállt.");
        }
    }

    public class Bicikli : IJarmu
    {
        public void Indit()
        {
            Console.WriteLine("A bicikli gurulni kezd.");
        }

        public void Megall()
        {
            Console.WriteLine("A bicikli megállt.");
        }
    }
}
