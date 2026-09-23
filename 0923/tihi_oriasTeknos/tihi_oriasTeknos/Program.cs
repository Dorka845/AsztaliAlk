namespace tihi_oriasTeknos
{
    class Program
    {
        static void Main(string[] args)
        {
            Turtle tihi = new Turtle();

            Food rak = new Crab(8);
            Food salata = new Salad();

            tihi.Eat(rak);
            Console.WriteLine("Rák után:");
            Console.WriteLine("Jóllakottság: " + tihi.FedLevel);
            Console.WriteLine("Boldogság: " + tihi.Happiness);

            Console.WriteLine();

            tihi.Eat(salata);
            Console.WriteLine("Saláta után:");
            Console.WriteLine("Jóllakottság: " + tihi.FedLevel);
            Console.WriteLine("Boldogság: " + tihi.Happiness);
        }
    }
}
