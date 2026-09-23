namespace vadasztarsasag
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] animals = new Animal[3];

            animals[0] = new Rabbit("Nyúl");
            animals[1] = new PolarBear("Jegesmedve");
            animals[2] = new Squirell("Mókus");

            for(int i = 0; i < animals.Length; i++)
            {
                Console.WriteLine("Állat: " + animals[i].Name);
                Console.WriteLine("Prém ára: " + animals[i].getPrice() + " Ft");
                Console.WriteLine();
            }
        }
    }
}
